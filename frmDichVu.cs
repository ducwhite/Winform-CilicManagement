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
    public partial class frmDichVu : DevExpress.XtraEditors.XtraForm
    {
        bool Edit;
        public bool themmoi = true;
        Model1 dbcontext = new Model1();
        public frmDichVu()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void setNull()
        {
            txtMadichvu.Text = "";
            txtTenDV.Text = "";
            txtDVT.Text = "";
            txtDonGia.Text = "";
            txtMT.Text = "";
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
            txtMadichvu.ReadOnly = bl;
            txtTenDV.ReadOnly = bl;
            txtDVT.ReadOnly = bl;
            txtDonGia.ReadOnly = bl;
            txtMT.ReadOnly = bl;
        }
        public void HienThiDV(List<DICHVU>dICHVUs)
        {
            Model1 context = new Model1();
            List<DICHVU> Listdt = context.DICHVUs.ToList();
            lsvDV.Items.Clear();
            foreach (var item in Listdt)
            {
                ListViewItem listItem = new ListViewItem(item.MADV);

                listItem.SubItems.Add(item.TENDV);
                listItem.SubItems.Add(item.GIA.ToString());
                listItem.SubItems.Add(item.DONVITINH);
                listItem.SubItems.Add(item.MOTA);
                lsvDV.Items.Add(listItem);
            }
        }
            private void DichVu_Load(object sender, EventArgs e)
        {
            List<DICHVU> list = dbcontext.DICHVUs.ToList();
            setNull();
            setButton(true);
            setKhoa(true);
            HienThiDV(list);
        }

        private void lsvDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDV.SelectedItems.Count > 0)

            {
                txtMadichvu.Text = lsvDV.SelectedItems[0].SubItems[0].Text;
                txtTenDV.Text = lsvDV.SelectedItems[0].SubItems[1].Text;
                txtDonGia.Text = lsvDV.SelectedItems[0].SubItems[2].Text;
                txtDVT.Text = lsvDV.SelectedItems[0].SubItems[3].Text;
                txtMT.Text = lsvDV.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            Edit = false;
            themmoi = true;
            setNull();
            setButton(false);
            setKhoa(false);
            txtMadichvu.Focus();
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn muốn xoa", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl == DialogResult.OK)
            {
                if (lsvDV.Items.Count > 0)
                {
                    string MADV = lsvDV.SelectedItems[0].SubItems[0].Text;
                    DICHVU dv = dbcontext.DICHVUs.FirstOrDefault(s => s.MADV == MADV);
                    dbcontext.DICHVUs.Remove(dv);
                    dbcontext.SaveChanges();
                    HienThiDV(dbcontext.DICHVUs.ToList());
                }
            }
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            Edit = true;
            if (lsvDV.SelectedItems.Count > 0)
            {

                themmoi = false;
                setButton(false);
                setKhoa(false);

            }
            else
                MessageBox.Show("Mời chọn dòng cần sửa", "Thông báo!", MessageBoxButtons.OK);
            txtMadichvu.ReadOnly = true;

        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (KTnhap()==false)
            {
                if (Edit&&themmoi==false)
                {
                    DICHVU dv = dbcontext.DICHVUs.FirstOrDefault(s => s.MADV == txtMadichvu.Text);
                    dv.TENDV = txtTenDV.Text;
                    dv.MOTA = txtMT.Text;
                    dv.GIA = decimal.Parse(txtDonGia.Text);
                    dv.DONVITINH = txtDVT.Text;
                }
                else
                {
                    DICHVU dv = new DICHVU();
                    dv.MADV = txtMadichvu.Text;
                    dv.TENDV = txtTenDV.Text;
                    dv.MOTA = txtMT.Text;
                    dv.GIA = decimal.Parse(txtDonGia.Text);
                    dv.DONVITINH = txtDVT.Text;
                    dbcontext.DICHVUs.Add(dv);
                }
                dbcontext.SaveChanges();
                HienThiDV(dbcontext.DICHVUs.ToList());
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
        public bool KTnhap()
        {
            if (txtMadichvu.Text.Trim() == "" || txtTenDV.Text.Trim() == "" || txtDonGia.Text.Trim() == "" || txtDVT.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (txtMadichvu.Text.Trim().Length != 5)
            {
                MessageBox.Show("Mã dịch vụ phải có đúng 5 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (txtTenDV.Text.Length > 100)
            {
                MessageBox.Show("Tên chỉ nhập được tối đa 100 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (txtMT.Text.Length > 100)
            {
                MessageBox.Show("mô tả chỉ nhập được tối đa 100 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (txtDVT.Text.Length > 10)
            {
                MessageBox.Show("đơn vị tính chỉ nhập được tối đa 10 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung(txtMadichvu.Text, 0) == true&&themmoi==true)
            {
                MessageBox.Show("Mã bạn nhập đã trùng!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
           
            if (KTTrung(txtTenDV.Text, 1) == true)
            {
                MessageBox.Show("Bạn nhập đã trùng tên!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }

        int idex;
        private bool KTTrung(string str, int index)
        {
            for (int i = 0; i < lsvDV.Items.Count; i++)
            {
                if (i != idex && themmoi == false)
                {
                    if (lsvDV.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
                if (themmoi == true)
                {
                    if (lsvDV.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void bttXem_Click(object sender, EventArgs e)
        {
            //var frm = new frmctsddv();
            //frm.Show();
        }
    }
}