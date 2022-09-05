using DevExpress.XtraEditors;
using Quanlyphongkham.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYPHONGKHAMTU
{
    public partial class frmPhieucanLS : DevExpress.XtraEditors.XtraForm
    {
        bool Edit;
        public bool themmoi = true;
        Model1 dbcontext = new Model1();
        public frmPhieucanLS()
        {
            InitializeComponent();
        }

        private void frmPhieucanLS_Load(object sender, EventArgs e)
        {
            List<PHIEUCANLAMSANG> lists = dbcontext.PHIEUCANLAMSANGs.ToList();
            List<BENHNHAN> list = dbcontext.BENHNHANs.ToList();
            FillDataToComboBox(dbcontext.BENHNHANs.ToList());
            txttongtien.ReadOnly = true;
            render(lists);
            setNull();
            setButton(true);
            setKhoa(true);
        }   
        private void FillDataToComboBox(List<BENHNHAN> bENHNHANs)
        {
            cbbMaBN.DataSource = bENHNHANs;
            cbbMaBN.DisplayMember ="TENBN";
            cbbMaBN.ValueMember = "MABN";

        }

        public void setNull()
        {
            txtMaPCLS.Text = "";
            dttNgaylap.Text = "";
            cbbMaBN.Text = "";
        }

        void setButton(bool bl)
        {
            bttThem.Enabled = bl;
            bttXoa.Enabled = bl;
            bttSua.Enabled = bl;
            bttThoat.Enabled = bl;
            bttLuu.Enabled = !bl;
            bttHuy.Enabled = !bl;
        }

        void setKhoa(bool bl)
        {
            cbbMaBN.Enabled = !bl;
            txtMaPCLS.ReadOnly = bl;
            dttNgaylap.Enabled = !bl;
        }
        public void render(List<PHIEUCANLAMSANG> pHIEUCANLAMSANGs)
        {
            Model1 context = new Model1();
            List<PHIEUCANLAMSANG> Listdt = context.PHIEUCANLAMSANGs.ToList();
            lsvPCLS.Items.Clear();
            foreach (var item in Listdt)
            {
                ListViewItem listItem = new ListViewItem(item.MAPCLS);
                listItem.SubItems.Add(item.BENHNHAN.TENBN);
                listItem.SubItems.Add(item.NGAYLAP.ToString());
                listItem.SubItems.Add(item.TONGTIEN.ToString());
                lsvPCLS.Items.Add(listItem);
            }
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            Edit = false;
            themmoi = true;
            setNull();
            setButton(false);
            setKhoa(false);
            txtMaPCLS.Focus();
            txttongtien.Text = "0";
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn muốn xoa", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl == DialogResult.OK)
            {
                if (lsvPCLS.Items.Count > 0)
                {
                    string MaPCLS = lsvPCLS.SelectedItems[0].SubItems[0].Text;
                    PHIEUCANLAMSANG dv = dbcontext.PHIEUCANLAMSANGs.FirstOrDefault(s => s.MAPCLS == MaPCLS);
                    dbcontext.PHIEUCANLAMSANGs.Remove(dv);
                    
                    dbcontext.SaveChanges();
                    render(dbcontext.PHIEUCANLAMSANGs.ToList());
                }
            }
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            Edit = true;
            if (lsvPCLS.SelectedItems.Count > 0)
            {

                themmoi = false;
                setButton(false);
                setKhoa(false);

            }
            else
                MessageBox.Show("Mời chọn dòng cần sửa", "Thông báo!", MessageBoxButtons.OK);
            txtMaPCLS.ReadOnly = true;
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (KTnhap()==false)
            {
                if (Edit&&themmoi==false)
                {
                    PHIEUCANLAMSANG p = dbcontext.PHIEUCANLAMSANGs.FirstOrDefault(s => s.MAPCLS == txtMaPCLS.Text);
                    p.MABN = cbbMaBN.SelectedValue.ToString();
                    p.NGAYLAP = dttNgaylap.Value.Date;
                    p.TONGTIEN = decimal.Parse(txttongtien.Text);
                }
                else
                {
                    PHIEUCANLAMSANG p = new PHIEUCANLAMSANG();
                    p.MAPCLS = txtMaPCLS.Text;
                    p.MABN = cbbMaBN.SelectedValue.ToString();
                    p.NGAYLAP = dttNgaylap.Value.Date;
                    p.TONGTIEN = decimal.Parse(txttongtien.Text);
                    dbcontext.PHIEUCANLAMSANGs.Add(p);
                }
                dbcontext.SaveChanges();
                render(dbcontext.PHIEUCANLAMSANGs.ToList());
                setNull();
                setKhoa(true);
                setButton(true);
            }
           
        }

        private void bttHuy_Click(object sender, EventArgs e)
        {
            setButton(true);
            setNull();
            setKhoa(true);
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Yes để thoát !", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void cbbMaBN_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lsvPCLS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvPCLS.SelectedItems.Count > 0)
            {
                txtMaPCLS.Text = lsvPCLS.SelectedItems[0].SubItems[0].Text;
                cbbMaBN.Text = lsvPCLS.SelectedItems[0].SubItems[1].Text;
                dttNgaylap.Text = lsvPCLS.SelectedItems[0].SubItems[2].Text;
            }
        }
        public bool KTnhap()
        {
            if (txtMaPCLS.Text.Trim() == "" || dttNgaylap.Text.Trim() == "" || cbbMaBN.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (txtMaPCLS.Text.Trim().Length != 7)
            {
                MessageBox.Show("Mã mã PCLS phải có đúng 7 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (dttNgaylap.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày lập không quá hiện tại!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }

            if (KTTrung(txtMaPCLS.Text, 0) == true&&themmoi==true)
            {
                MessageBox.Show("Bạn nhập đã trùng mã!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
           
            return false;
        }

        int idex;
        private bool KTTrung(string str, int index)
        {
            for (int i = 0; i < lsvPCLS.Items.Count; i++)
            {
                if (i != idex && themmoi == false)
                {
                    if (lsvPCLS.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
                if (themmoi == true)
                {
                    if (lsvPCLS.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void dttNgaylap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmctsddv frm = new frmctsddv();
            frm.Show();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}