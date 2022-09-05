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
    public partial class FrmDMLoaiThuoc : DevExpress.XtraEditors.XtraForm
    {
        bool themmoi = true;
        LoaiThuoc lt = new LoaiThuoc();
        int idex;
        public FrmDMLoaiThuoc()
        {
            InitializeComponent();
        }
        public void HienThiLoaiThuoc()
        {
            lsvLoaiThuoc.Items.Clear();
            DataTable dt = lt.LayDSLoaiThuoc();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvLoaiThuoc.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
            }
        }

        public void setNull()
        {
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
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
            txtMaLoai.ReadOnly = bl;
            txtTenLoai.ReadOnly = bl;
        }
        private void FrmDMLoaiThuoc_Load(object sender, EventArgs e)
        {
            setNull();
            setButton(true);
            setKhoa(true);
            HienThiLoaiThuoc();
        }

        private void lsvLoaiThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvLoaiThuoc.SelectedItems.Count > 0)
            {
                txtMaLoai.Text = lsvLoaiThuoc.SelectedItems[0].SubItems[0].Text;
                txtTenLoai.Text = lsvLoaiThuoc.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setButton(false);
            setKhoa(false);
            txtMaLoai.Focus();
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            if (lsvLoaiThuoc.SelectedItems.Count > 0)
            {
                themmoi = false;
                setButton(false);
                setKhoa(false);
                txtMaLoai.ReadOnly = true;
                idex = lsvLoaiThuoc.SelectedIndices[0];
            }
            else
                MessageBox.Show("Mời chọn dòng cần sửa", "Thông báo!", MessageBoxButtons.OK);
        }

        private void bttHuy_Click(object sender, EventArgs e)
        {
            setNull();
            setButton(true);
            setKhoa(true);
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc thoát không!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            if (lsvLoaiThuoc.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    lt.XoaLoaiThuoc(lsvLoaiThuoc.SelectedItems[0].SubItems[0].Text);
                    lsvLoaiThuoc.Items.RemoveAt(lsvLoaiThuoc.SelectedIndices[0]);
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
                    lt.ThemLoaiThuoc(txtMaLoai.Text, txtTenLoai.Text);
                    MessageBox.Show("Thêm mới thành công!", "Thông báo!", MessageBoxButtons.OK);
                }

                else
                {
                    lt.CapNhatLoaiThuoc(txtMaLoai.Text, txtTenLoai.Text);
                    MessageBox.Show("Cập nhật thành công!", "Thông báo!", MessageBoxButtons.OK);
                }
                HienThiLoaiThuoc();
                setNull();
                setKhoa(true);
                setButton(true);
            }
            
        }

        public bool KTnhap()
        {
            if(txtMaLoai.Text.Trim() == "" || txtTenLoai.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if(txtMaLoai.Text.Trim().Length != 5)
            {
                MessageBox.Show("Mã loại phải có đúng 5 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if(txtTenLoai.Text.Length > 100)
            {
                MessageBox.Show("Tên chỉ nhập được tối đa 100 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung(txtMaLoai.Text, 0) == true && themmoi == true)
            {
                MessageBox.Show("Bạn nhập đã trùng mã!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung(txtTenLoai.Text,1) == true)
            {
                MessageBox.Show("Bạn nhập đã trùng tên!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }

        private bool KTTrung(string str, int index)
        {
            for (int i = 0; i < lsvLoaiThuoc.Items.Count; i++)
            {
                if (i != idex && themmoi == false)
                {
                    if (lsvLoaiThuoc.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
                if (themmoi == true)
                {
                    if (lsvLoaiThuoc.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
            }
                return false;
        }
    }
}