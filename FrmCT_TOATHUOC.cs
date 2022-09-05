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
    public partial class FrmCT_TOATHUOC : DevExpress.XtraEditors.XtraForm
    {
        bool themmoi = false;
        string slcu = "";
        CT_TOATHUOC ct = new CT_TOATHUOC();
        public FrmCT_TOATHUOC()
        {
            InitializeComponent();
        }

        public void HienThiDS()
        {
            lsvCT.Items.Clear();
            DataTable dt = ct.LayDS();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvCT.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
            }
        }

        public void HienThiDSToa()
        {
            DataTable dt = ct.LayDSToa();
            cbbMaToa.DataSource = dt;
            cbbMaToa.DisplayMember = "MATOATHUOC";
            cbbMaToa.ValueMember = "MATOATHUOC";
        }

        public void HienThiDSThuoc()
        {
            DataTable dt = ct.LayDSThuoc();
            cbbTenThuoc.DataSource = dt;
            cbbTenThuoc.DisplayMember = "TEN";
            cbbTenThuoc.ValueMember = "MATHUOC";
        }

        public void setNull()
        {
            cbbMaToa.Text = "";
            cbbTenThuoc.Text = "";
            txtSL.Text = "";
            txtMaPhieuKB.Text = "";
            txtMaPhieuKQ.Text = "";
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
            cbbMaToa.Enabled = !bl;
            cbbTenThuoc.Enabled = !bl;
            txtSL.ReadOnly = bl;
        }

        private void FrmCT_TOATHUOC_Load(object sender, EventArgs e)
        {
            txtMaPhieuKB.ReadOnly = true;
            txtMaPhieuKQ.ReadOnly = true;
            HienThiDS();
            HienThiDSToa();
            HienThiDSThuoc();
            setButton(true);
            setKhoa(true);
            setNull();
        }

        private void lsvCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvCT.SelectedItems.Count > 0)
            {
                cbbMaToa.Text = lsvCT.SelectedItems[0].SubItems[0].Text;
                txtMaPhieuKQ.Text = lsvCT.SelectedItems[0].SubItems[1].Text;
                txtMaPhieuKB.Text = lsvCT.SelectedItems[0].SubItems[2].Text;
                cbbTenThuoc.Text = lsvCT.SelectedItems[0].SubItems[3].Text;
                txtSL.Text = lsvCT.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setButton(false);
            setKhoa(false);
            cbbMaToa.Focus();
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            if (lsvCT.SelectedItems.Count > 0)
            {
                themmoi = false;
                setButton(false);
                setKhoa(false);
                slcu = txtSL.Text;
                cbbMaToa.Enabled = false;
                cbbTenThuoc.Enabled = false;
            }
            else
                MessageBox.Show("Mời chọn dòng cần sửa", "Thông báo!", MessageBoxButtons.OK);
        }

        private void bttHuy_Click(object sender, EventArgs e)
        {
            HienThiDS();
            HienThiDSThuoc();
            HienThiDSToa();
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
            if (lsvCT.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    ct.Xoa(cbbMaToa.Text, cbbTenThuoc.SelectedValue.ToString(), txtSL.Text);
                    lsvCT.Items.RemoveAt(lsvCT.SelectedIndices[0]);
                    ct.TinhTien(cbbMaToa.Text);
                    MessageBox.Show("Xóa thành công!", "Thông báo!", MessageBoxButtons.OK);
                    setNull();
                }
            }
            else
                MessageBox.Show("Bạn cần chọn dòng muốn xóa", "Thông báo", MessageBoxButtons.OK);
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (KTnhap() == false)
            {
                if (themmoi == true)
                {
                    ct.Them(cbbMaToa.Text,txtMaPhieuKQ.Text,txtMaPhieuKB.Text, cbbTenThuoc.SelectedValue.ToString(), txtSL.Text);
                    MessageBox.Show("Thêm mới thành công!", "Thông báo!", MessageBoxButtons.OK);
                    ct.TinhTien(cbbMaToa.Text);
                }

                else
                {
                    cbbMaToa.Enabled = false;
                    cbbTenThuoc.Enabled = false;
                    ct.CapNhat(cbbMaToa.Text, cbbTenThuoc.SelectedValue.ToString(), txtSL.Text,slcu);
                    MessageBox.Show("Cập nhật thành công!", "Thông báo!", MessageBoxButtons.OK);
                    ct.TinhTien(cbbMaToa.Text);
                }
                HienThiDS();
                HienThiDSToa();
                HienThiDSThuoc();
                setNull();
                setKhoa(true);
                setButton(true);
            }
        }

        public bool KTnhap()
        {
            if (cbbMaToa.Text.Trim() == "" || txtMaPhieuKB.Text.Trim() == "" || cbbTenThuoc.Text.Trim() == "" || txtSL.Text == "" || txtMaPhieuKQ.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (themmoi == true && int.Parse(txtSL.Text) > ct.LayDSSLTHUOC(cbbTenThuoc.SelectedValue.ToString()))
            {
                MessageBox.Show("Số lượng thuốc cần lớn hơn số lượng trong kho!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (themmoi == false && int.Parse(txtSL.Text) > ct.LayDSSLTHUOC_EDIT(cbbTenThuoc.SelectedValue.ToString(),slcu))
            {
                MessageBox.Show("Số lượng thuốc cần lớn hơn số lượng trong kho!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung(cbbMaToa.Text, 0, cbbTenThuoc.Text, 3) == true && themmoi == true)
            {
                MessageBox.Show("Bạn nhập đã trùng mã toa và thuốc!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }

        private bool KTTrung(string str, int index, string str1, int index1)
        {
            for (int i = 0; i < lsvCT.Items.Count; i++)
            {
                if (lsvCT.Items[i].SubItems[index].Text == str && lsvCT.Items[i].SubItems[index1].Text == str1)
                {
                    return true;
                }
            }
            return false;
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbbMaToa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt = ct.LayDSPhieuKQ(cbbMaToa.SelectedValue.ToString());
            txtMaPhieuKQ.Text = dt.Rows[0][0].ToString();
            txtMaPhieuKB.Text = dt.Rows[0][1].ToString();
        }

        private void cbbMaToa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}