using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYPHONGKHAMTU.Entities;

namespace QUANLYPHONGKHAMTU
{
    public partial class FrmDanhMucThuoc : DevExpress.XtraEditors.XtraForm
    {
        public bool themmoi = false;
        Thuoc thuoc = new Thuoc();
        int idex;
        public FrmDanhMucThuoc()
        {
            InitializeComponent();
        }
        public void HienThiThuoc()
        {
            lsvThuoc.Items.Clear();
            DataTable dt = thuoc.LayDSThuoc();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvThuoc.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
            }
        }

        public void setNull()
        {
            txtMaSo.Text = "";
            txtTenThuoc.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtDVT.Text = "";
            cbbTenL.Text = "";
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
            txtMaSo.ReadOnly = bl;
            txtTenThuoc.ReadOnly = bl;
            txtSoLuong.ReadOnly = bl;
            txtDonGia.ReadOnly = bl;
            txtDVT.ReadOnly = bl;
            cbbTenL.Enabled = !bl;
        }

        void HienthiLoaiThuoc()
        {
            DataTable dt = thuoc.LayDSLoaiThuoc();
            cbbTenL.DataSource = dt;
            cbbTenL.DisplayMember = "TENLOAI";
            cbbTenL.ValueMember = "MALOAI";
        }


        private void FrmDanhMucThuoc_Load(object sender, EventArgs e)
        {
            setNull();
            setButton(true);
            setKhoa(true);
            HienThiThuoc();
            HienthiLoaiThuoc();
        }

        private void lsvThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvThuoc.SelectedItems.Count > 0)
            {
                txtMaSo.Text = lsvThuoc.SelectedItems[0].SubItems[0].Text;
                txtTenThuoc.Text = lsvThuoc.SelectedItems[0].SubItems[1].Text;
                txtSoLuong.Text = lsvThuoc.SelectedItems[0].SubItems[2].Text;
                txtDonGia.Text = lsvThuoc.SelectedItems[0].SubItems[3].Text;
                txtDVT.Text = lsvThuoc.SelectedItems[0].SubItems[4].Text;
                cbbTenL.Text = lsvThuoc.SelectedItems[0].SubItems[5].Text;
            }
        }


        private void bttThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setNull();
            setButton(false);
            setKhoa(false);
            txtMaSo.Focus();
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            if (lsvThuoc.SelectedItems.Count > 0)
            {
                themmoi = false;
                setButton(false);
                setKhoa(false);
                txtMaSo.ReadOnly = true;
                idex = lsvThuoc.SelectedIndices[0];
            }
            else
                MessageBox.Show("Mời chọn dòng cần sửa", "Thông báo!", MessageBoxButtons.OK);
        }

        

        private void bttHuy_Click(object sender, EventArgs e)
        {
            setButton(true);
            setNull();
            setKhoa(true);
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc thoát không!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            if (lsvThuoc.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    thuoc.XoaThuoc(lsvThuoc.SelectedItems[0].SubItems[0].Text);
                    lsvThuoc.Items.RemoveAt(lsvThuoc.SelectedIndices[0]);
                    MessageBox.Show("Xóa thành công!", "Thông báo!", MessageBoxButtons.OK);
                    setNull();
                }
            }
            else
                MessageBox.Show("Bạn cần chọn dòng muốn xóa", "Thông báo", MessageBoxButtons.OK);
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if(KTnhap() == false)
            {
                if (themmoi == true)
                {
                    thuoc.ThemThuoc(txtMaSo.Text, txtTenThuoc.Text, txtSoLuong.Text, txtDonGia.Text, txtDVT.Text, cbbTenL.Text);
                    MessageBox.Show("Thêm mới thành công!", "Thông báo!", MessageBoxButtons.OK);
                }

                else
                {
                    thuoc.CapNhatThuoc(txtMaSo.Text, txtTenThuoc.Text, txtSoLuong.Text, txtDonGia.Text, txtDVT.Text, cbbTenL.Text);
                    MessageBox.Show("Cập nhật thành công!", "Thông báo!", MessageBoxButtons.OK);
                }
                HienThiThuoc();
                setNull();
                setKhoa(true);
                setButton(true);
            }
        }

        public bool KTnhap()
        {
            if (txtMaSo.Text.Trim() == "" || txtTenThuoc.Text.Trim() == "" || txtSoLuong.Text.Trim() == "" || txtDonGia.Text.Trim() == "" || txtDVT.Text.Trim() == "" || cbbTenL.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (txtMaSo.Text.Length != 5)
            {
                MessageBox.Show("Mã thuốc phải có đúng 5 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (txtTenThuoc.Text.Length > 100)
            {
                MessageBox.Show("Tên chỉ nhập được tối đa 100 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }            
            if (txtDVT.Text.Length > 10)
            {
                MessageBox.Show("Đơn vị tính chỉ nhập được tối đa 10 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung(txtMaSo.Text, 0) == true && themmoi == true)
            {
                MessageBox.Show("Bạn nhập trùng mã thuốc!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung(txtTenThuoc.Text, 1) == true)
            {
                MessageBox.Show("Bạn nhập trùng tên!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }

        private bool KTTrung(string str, int index)
        {
            for (int i = 0; i < lsvThuoc.Items.Count; i++)
            {
                if (i != idex && themmoi == false)
                {
                    if (lsvThuoc.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
                if (themmoi == true)
                {
                    if (lsvThuoc.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
            }
                return false;
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}