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
    public partial class frmPhieukhambenh : DevExpress.XtraEditors.XtraForm
    {
        bool Edit;
        public bool themmoi = true;
        public string timkiem = "";
        Model1 dbcontext = new Model1();
        public frmPhieukhambenh()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPhieukhambenh_Load(object sender, EventArgs e)
        {
            List<PHIEUKHAMBENH> lists = dbcontext.PHIEUKHAMBENHs.ToList();
            FillDataToComboBox2(dbcontext.PHONGKHAMs.ToList());
            FillDataToComboBox1(dbcontext.LOAIKHAMs.ToList());
            FillDataToComboBox(dbcontext.BENHNHANs.ToList());
            FillDataToComboBox3(dbcontext.NVs.ToList());
            render(lists);
            setNull();
            setButton(true);
            setKhoa(true);
            txttimkiem.Text = timkiem;
        }
        public void setNull()
        {
            cbbMaLK.Text = "";
            dttNgaylap.Text = "";
            cbbMaBN.Text = "";
            cbbMaNV.Text = "";
            cbbMaPK.Text = "";
            txtMaPKB.Text = "";
            txtGhiChu.Text = "";
            radiobtdakham.Checked = false;
            radiobtchuakham.Checked = false;
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
            txtMaPKB.ReadOnly = bl;
            dttNgaylap.Enabled = !bl;
            txtGhiChu.ReadOnly = bl;
            cbbMaLK.Enabled = !bl;
            cbbMaNV.Enabled = !bl;
            cbbMaPK.Enabled = !bl;
            radiobtchuakham.Enabled = !bl;
            radiobtdakham.Enabled = !bl;
        }
        private void FillDataToComboBox(List<BENHNHAN> bENHNHANs)
        {
            cbbMaBN.DataSource = bENHNHANs;
            cbbMaBN.DisplayMember = "TENBN";
            cbbMaBN.ValueMember = "MABN";

        }
        private void FillDataToComboBox1(List<LOAIKHAM> lOAIKHAMs)
        {
            cbbMaLK.DataSource = lOAIKHAMs;
            cbbMaLK.DisplayMember = "TEN";
            cbbMaLK.ValueMember = "MALOAIK";
        }

        private void FillDataToComboBox2(List<PHONGKHAM> pHONGKHAMs)
        {
            cbbMaPK.DataSource = pHONGKHAMs;
            cbbMaPK.DisplayMember = "TENPK";
            cbbMaPK.ValueMember = "MAPK";
        }
        private void FillDataToComboBox3(List<NV> nVs)
        {
            cbbMaNV.DataSource = nVs;
            cbbMaNV.DisplayMember = "TENNV";
            cbbMaNV.ValueMember = "MANV";
        }
        public void render(List<PHIEUKHAMBENH> pHIEUKHAMBENHs)
        {
            
            lsvPKB.Items.Clear();
            foreach (var item in pHIEUKHAMBENHs)
            {
                ListViewItem listItem = new ListViewItem(item.MAPHIEUKB);
                listItem.SubItems.Add(item.PHONGKHAM.TENPK);
                listItem.SubItems.Add(item.NV.TENNV);
                listItem.SubItems.Add(item.LOAIKHAM.TEN);
                listItem.SubItems.Add(item.BENHNHAN.TENBN);
                listItem.SubItems.Add(item.NGAYLAP.ToString());
                if (item.TINHTRANG.ToString()=="True")
                {
                    listItem.SubItems.Add("Đã khám");
                }
                else
                {
                    listItem.SubItems.Add("Chưa khám");
                }
                listItem.SubItems.Add(item.GHICHU);
                lsvPKB.Items.Add(listItem);
            }
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            Edit = false;
            themmoi = true;
            setNull();
            setButton(false);
            setKhoa(false);
            txtMaPKB.Focus();
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn muốn xoa", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl == DialogResult.OK)
            {
                if (lsvPKB.Items.Count > 0)
                {
                    string MaPCLS = lsvPKB.SelectedItems[0].SubItems[0].Text;
                    PHIEUKHAMBENH pk = dbcontext.PHIEUKHAMBENHs.FirstOrDefault(s => s.MAPK == MaPCLS);
                    dbcontext.PHIEUKHAMBENHs.Remove(pk);
                    dbcontext.SaveChanges();
                    render(dbcontext.PHIEUKHAMBENHs.ToList());
                }
            }
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            Edit = true;
            if (lsvPKB.SelectedItems.Count > 0)
            {

                themmoi = false;
                setButton(false);
                setKhoa(false);

            }
            else
                MessageBox.Show("Mời chọn dòng cần sửa", "Thông báo!", MessageBoxButtons.OK);
            txtMaPKB.ReadOnly = true;
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (KTnhap()==false)
            {
                if (Edit&&themmoi==false)
                {
                    PHIEUKHAMBENH p = dbcontext.PHIEUKHAMBENHs.FirstOrDefault(s => s.MAPHIEUKB == txtMaPKB.Text);
                    p.MABN = cbbMaBN.SelectedValue.ToString();
                    p.NGAYLAP = dttNgaylap.Value.Date;
                    p.MANV = cbbMaNV.SelectedValue.ToString();
                    p.MAPK = cbbMaPK.SelectedValue.ToString();
                    p.MALOAIK = cbbMaLK.SelectedValue.ToString();
                    if (radiobtdakham.Checked==true)
                    {
                        p.TINHTRANG = true;
                    }
                    else
                    {
                        p.TINHTRANG = false;
                    }
                    p.GHICHU = txtGhiChu.Text;
                }
                else
                {
                    PHIEUKHAMBENH p = new PHIEUKHAMBENH();
                    p.MAPHIEUKB = txtMaPKB.Text;
                    p.MABN = cbbMaBN.SelectedValue.ToString();
                    p.NGAYLAP = dttNgaylap.Value.Date;
                    p.MANV = cbbMaNV.SelectedValue.ToString();
                    p.MAPK = cbbMaPK.SelectedValue.ToString();
                    p.MALOAIK = cbbMaLK.SelectedValue.ToString();
                    if (radiobtdakham.Checked == true)
                    {
                        p.TINHTRANG = true;
                    }
                    else
                    {
                        p.TINHTRANG = false;
                    }
                    p.GHICHU = txtGhiChu.Text;
                    dbcontext.PHIEUKHAMBENHs.Add(p);
                }
                dbcontext.SaveChanges();
                render(dbcontext.PHIEUKHAMBENHs.ToList());
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

        private void lsvPKB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvPKB.SelectedItems.Count > 0)
            {
                txtMaPKB.Text = lsvPKB.SelectedItems[0].SubItems[0].Text;
                cbbMaPK.Text = lsvPKB.SelectedItems[0].SubItems[1].Text;
                cbbMaNV.Text = lsvPKB.SelectedItems[0].SubItems[2].Text;
                cbbMaLK.Text = lsvPKB.SelectedItems[0].SubItems[3].Text;
                cbbMaBN.Text = lsvPKB.SelectedItems[0].SubItems[4].Text;
                dttNgaylap.Text = lsvPKB.SelectedItems[0].SubItems[5].Text;
                if (lsvPKB.SelectedItems[0].SubItems[6].Text=="Đã khám")
                {
                    radiobtdakham.Checked = true;
                }
                else
                {
                    radiobtchuakham.Checked = true;
                }
                txtGhiChu.Text = lsvPKB.SelectedItems[0].SubItems[7].Text;
            }
        }
        public bool KTnhap()
        {
            if (txtMaPKB.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo!", MessageBoxButtons.OK);
            }
            if (txtMaPKB.Text.Trim().Length != 6)
            {
                MessageBox.Show("Mã mã PCLS phải có đúng 6 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (dttNgaylap.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày lập không quá hiện tại!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }

            if (KTTrung(txtMaPKB.Text, 0) == true && themmoi == true)
            {
                MessageBox.Show("Bạn nhập đã trùng mã!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }

            return false;
        }

        int idex;
        private bool KTTrung(string str, int index)
        {
            for (int i = 0; i < lsvPKB.Items.Count; i++)
            {
                if (i != idex && themmoi == false)
                {
                    if (lsvPKB.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
                if (themmoi == true)
                {
                    if (lsvPKB.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            List<PHIEUKHAMBENH> listsearch = dbcontext.PHIEUKHAMBENHs
                .Where(p => (string.IsNullOrEmpty(txttimkiem.Text) || p.MAPHIEUKB.Contains(txttimkiem.Text))
                )
                .ToList();
            render(listsearch);
           
        }
    }
}