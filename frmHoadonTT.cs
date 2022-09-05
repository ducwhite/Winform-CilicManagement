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

    public partial class frmHoadonTT : DevExpress.XtraEditors.XtraForm
    {
        bool Edit;
        public bool themmoi = false;
        Model1 dbcontext = new Model1();
        public frmHoadonTT()
        {
            InitializeComponent();
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            Edit = false;
            themmoi = true;
            setNull();
            setButton(false);
            setKhoa(false);
            txtmahd.Focus();
            txttongtien.Text = "0";
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn muốn xoa", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl == DialogResult.OK)
            {
                if (listView1.Items.Count > 0)
                {
                    string MAHD = listView1.SelectedItems[0].SubItems[0].Text;
                    HOADONTHANHTOAN nv = dbcontext.HOADONTHANHTOANs.FirstOrDefault(s => s.MAHD == MAHD);

                    //MessageBox.Show(MABN);
                    dbcontext.HOADONTHANHTOANs.Remove(nv);
                    dbcontext.SaveChanges();
                    render(dbcontext.HOADONTHANHTOANs.ToList());
                }
            }
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            Edit = true;
            if (listView1.SelectedItems.Count > 0)
            {
                themmoi = false;
                setButton(false);
                setKhoa(false);
            }
            else
                MessageBox.Show("Mời chọn dòng cần sửa", "Thông báo!", MessageBoxButtons.OK);
            txtmahd.ReadOnly = true;
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (KTnhap()==false)
            {
                if (Edit&&themmoi==false)
                {
                    HOADONTHANHTOAN hd = dbcontext.HOADONTHANHTOANs.FirstOrDefault(s => s.MAHD == txtmahd.Text);
                    hd.MABN = cbbtenbn.SelectedValue.ToString();
                    hd.NGAYLAP = dtngaylap.Value.Date;
                    hd.MANV = cbbtennv.SelectedValue.ToString();
                }
                else
                {
                    HOADONTHANHTOAN hd = new HOADONTHANHTOAN();
                    hd.MAHD = txtmahd.Text;
                    hd.MABN = cbbtenbn.SelectedValue.ToString();
                    hd.NGAYLAP = dtngaylap.Value.Date;
                    hd.MANV = cbbtennv.SelectedValue.ToString();
                    hd.TONGTIEN = decimal.Parse(txttongtien.Text);
                    dbcontext.HOADONTHANHTOANs.Add(hd);
                }
                dbcontext.SaveChanges();
                render(dbcontext.HOADONTHANHTOANs.ToList());
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

        private void frmHoadonTT_Load(object sender, EventArgs e)
        {
            List<HOADONTHANHTOAN> list = dbcontext.HOADONTHANHTOANs.ToList();
            List<BENHNHAN> listss = dbcontext.BENHNHANs.ToList();
            List<NV> lists = dbcontext.NVs.ToList();
            FillDataToComboBox(lists);
            FillDataToComboBox1(listss);
            render(list);
            setNull();
            setButton(true);
            setKhoa(true);
            txttongtien.ReadOnly = true;
        }
        public void setNull()
        {
            txtmahd.Text = "";
            txttongtien.Text = "";
            dtngaylap.Text = "";
            cbbtenbn.Text = "";
            cbbtennv.Text = "";
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
            txtmahd.ReadOnly = bl;          
            cbbtenbn.Enabled = !bl;
            cbbtennv.Enabled = !bl;
        }

        public void FillDataToComboBox(List<NV> nVs)

        {
            cbbtennv.DataSource = nVs;
            cbbtennv.DisplayMember = "TENNV";
            cbbtennv.ValueMember = "MANV";

        }
        public void FillDataToComboBox1(List<BENHNHAN> bENHNHANs)

        {
            cbbtenbn.DataSource = bENHNHANs;
            cbbtenbn.DisplayMember = "TENBN";
            cbbtenbn.ValueMember = "MABN";
        }
        public void render(List<HOADONTHANHTOAN> hOADONTHANHTOANs)
        {


            Model1 context = new Model1();
            List<HOADONTHANHTOAN> Lists = context.HOADONTHANHTOANs.ToList();
            List<NV> Listnv = context.NVs.ToList();
            List<BENHNHAN> Listbn = context.BENHNHANs.ToList();
            listView1.Items.Clear();
            foreach (var item in Lists)
            {
                ListViewItem listItem = new ListViewItem(item.MAHD);

                listItem.SubItems.Add(item.BENHNHAN.TENBN);
                listItem.SubItems.Add(item.NGAYLAP.ToString());
                listItem.SubItems.Add(item.NV.TENNV);
                listItem.SubItems.Add(item.TONGTIEN.ToString());
                listView1.Items.Add(listItem);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)

            {
                txtmahd.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txttongtien.Text = listView1.SelectedItems[0].SubItems[4].Text;
                dtngaylap.Text = listView1.SelectedItems[0].SubItems[2].Text;
                cbbtenbn.Text = listView1.SelectedItems[0].SubItems[1].Text;
                cbbtennv.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }
        }
        public bool KTnhap()
        {
            if (txtmahd.Text.Trim() == ""  || cbbtennv.Text.Trim() == "" || dtngaylap.Text.Trim() == "" || cbbtenbn.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (txtmahd.Text.Trim().Length != 5)
            {
                MessageBox.Show("Mã thuốc phải có đúng 5 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }           

            if (KTTrung(txtmahd.Text, 0) == true&&themmoi==true)
            {
                MessageBox.Show("mã bạn nhập đã trùng!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }
        int idex;
        private bool KTTrung(string str, int index)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (i != idex && themmoi == false)
                {
                    if (listView1.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
                if (themmoi == true)
                {
                    if (listView1.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        private void bttXem_Click(object sender, EventArgs e)
        {
            var frm = new FrmCT_HoaDon();
            frm.Show();
        }
    }
}