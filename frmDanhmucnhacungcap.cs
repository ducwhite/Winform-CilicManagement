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
    public partial class frmDanhmucnhacungcap : DevExpress.XtraEditors.XtraForm
    {
        public bool themmoi = false;
        NCC ncc = new NCC();
        int idex;
        public frmDanhmucnhacungcap()
        {
            InitializeComponent();
        }

        public void HienThiNCC()
        {
            lsvNCC.Items.Clear();
            DataTable dt = ncc.LayDSNCC();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvNCC.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
            }
        }

        public void setNull()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtWebsite.Text = "";
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
            txtMaNCC.ReadOnly = bl;
            txtTenNCC.ReadOnly = bl;
            txtDiaChi.ReadOnly = bl;
            txtDienThoai.ReadOnly = bl;
            txtEmail.ReadOnly = bl;
            txtWebsite.ReadOnly = bl;
        }
        private void frmDanhmucnhacungcap_Load(object sender, EventArgs e)
        {
            setNull();
            setButton(true);
            setKhoa(true);
            HienThiNCC();
        }

        private void lsvNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvNCC.SelectedItems.Count > 0)
            {
                txtMaNCC.Text = lsvNCC.SelectedItems[0].SubItems[0].Text;
                txtTenNCC.Text = lsvNCC.SelectedItems[0].SubItems[1].Text;
                txtDienThoai.Text = lsvNCC.SelectedItems[0].SubItems[2].Text;
                txtDiaChi.Text = lsvNCC.SelectedItems[0].SubItems[3].Text;
                txtEmail.Text = lsvNCC.SelectedItems[0].SubItems[4].Text;
                txtWebsite.Text = lsvNCC.SelectedItems[0].SubItems[5].Text;
            }
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setButton(false);
            setKhoa(false);
            txtMaNCC.Focus();
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            if (lsvNCC.SelectedItems.Count > 0)
            {
                themmoi = false;
                setButton(false);
                setKhoa(false);
                txtMaNCC.ReadOnly = true;
                idex = lsvNCC.SelectedIndices[0];
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
            if(MessageBox.Show("Bạn có chắc thoát không!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            if(lsvNCC.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không!", "Thông báo!", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    ncc.XoaNCC(lsvNCC.SelectedItems[0].SubItems[0].Text);
                    lsvNCC.Items.RemoveAt(lsvNCC.SelectedIndices[0]);
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
                    ncc.ThemNCC(txtMaNCC.Text, txtTenNCC.Text, txtDienThoai.Text, txtDiaChi.Text, txtEmail.Text, txtWebsite.Text);
                    MessageBox.Show("Thêm mới thành công!", "Thông báo!", MessageBoxButtons.OK);
                }

                else
                {
                    ncc.CapNhatNCC(txtMaNCC.Text, txtTenNCC.Text, txtDienThoai.Text, txtDiaChi.Text, txtEmail.Text, txtWebsite.Text);
                    MessageBox.Show("Cập nhật thành công!", "Thông báo!", MessageBoxButtons.OK);
                }
                HienThiNCC();
                setNull();
                setKhoa(true);
                setButton(true);
            }
            
        }

        public bool KTnhap()
        {
            if(txtMaNCC.Text.Trim() == "" || txtTenNCC.Text.Trim() == "" || txtDienThoai.Text.Trim() == "" || txtDiaChi.Text.Trim() == "" || txtWebsite.Text.Trim() == "" || txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if(txtMaNCC.Text.Trim().Length != 6)
            {
                MessageBox.Show("Mã nhà cung cấp phải có đúng 6 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if(txtTenNCC.Text.Length > 100)
            {
                MessageBox.Show("Tên chỉ nhập được tối đa 100 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }

            if (txtDienThoai.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải có đúng 10 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (txtDiaChi.Text.Length > 100)
            {
                MessageBox.Show("Địa chỉ chỉ nhập được tối đa 100 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (txtEmail.Text.Length > 50)
            {
                MessageBox.Show("Email chỉ nhập được tối đa 50 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (txtWebsite.Text.Length > 60)
            {
                MessageBox.Show("Website chỉ nhập được tối đa 60 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if(KTTrung(txtMaNCC.Text,0) == true && themmoi == true)
            {
                MessageBox.Show("Bạn nhập đã trùng mã nhà cung cấp!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung(txtTenNCC.Text,1) == true)
            {
                MessageBox.Show("Bạn nhập đã trùng tên!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung(txtDienThoai.Text, 2) == true)
            {
                MessageBox.Show("Bạn nhập đã trùng điện thoại!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung(txtEmail.Text, 4) == true)
            {
                MessageBox.Show("Bạn nhập đã trùng email!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung(txtWebsite.Text, 5) == true)
            {
                MessageBox.Show("Bạn nhập đã trùng website!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }

        private bool KTTrung(string str, int index)
        {
            for (int i = 0; i < lsvNCC.Items.Count; i++)
            {
                if(i != idex && themmoi == false)
                {
                    if (lsvNCC.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
                if(themmoi == true)
                {
                    if (lsvNCC.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
                
            }
            return false;
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void bttXem_Click(object sender, EventArgs e)
        {
            FrmCT_CungCapThuoc frm = new FrmCT_CungCapThuoc();
            frm.Show();
        }
    }
}