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
    public partial class FrmCTPhieuNT : Form
    {
        CT_PNT ct = new CT_PNT();
        bool themmoi = true;
        string slcu = "";
        public FrmCTPhieuNT()
        {
            InitializeComponent();
        }

        public void HienThiDS()
        {
            lsvCTPNT.Items.Clear();
            DataTable dt = ct.LayDS();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvCTPNT.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
            }
        }

        public void HienThiDSPhieu()
        {
            DataTable dt = ct.LayDSPhieu();
            cbbMaPhieu.DataSource = dt;
            cbbMaPhieu.DisplayMember = "MAPNT";
            cbbMaPhieu.ValueMember = "MAPNT";
        }

        public void HienThiDSThuoc()
        {
            DataTable dt = ct.LayDSThuoc();
            cbbTenThuoc.DataSource = dt;
            cbbTenThuoc.DisplayMember = "TEN";
            cbbTenThuoc.ValueMember = "MATHUOC";
            
        }

        public void HienThiDSNCC()
        {
            DataTable dt = ct.LayDSNCC();
            cbbTenNCC.DataSource = dt;
            cbbTenNCC.DisplayMember = "TENNCC";
            cbbTenNCC.ValueMember = "MANCC";
            
        }

        

        public void setNull()
        {
            cbbMaPhieu.Text = "";
            cbbTenNCC.Text = "";
            cbbTenThuoc.Text = "";
            txtSL.Text = "";
            txtDonGia.Text = "";
            txtDVT.Text = "";
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
            cbbMaPhieu.Enabled = !bl;
            cbbTenNCC.Enabled = !bl;
            cbbTenThuoc.Enabled = !bl;
            txtSL.ReadOnly = bl;
            txtDonGia.ReadOnly = bl;
            txtDVT.ReadOnly = bl;
        }


        private void FrmCTPhieuNT_Load(object sender, EventArgs e)
        {
            HienThiDS();
            HienThiDSPhieu();
            HienThiDSThuoc();
            HienThiDSNCC();
            setButton(true);
            setKhoa(true);
            setNull();
        }

        private void lsvCTPNT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvCTPNT.SelectedItems.Count > 0)
            {
                cbbMaPhieu.Text = lsvCTPNT.SelectedItems[0].SubItems[0].Text;
                cbbTenNCC.Text = lsvCTPNT.SelectedItems[0].SubItems[2].Text;
                cbbTenThuoc.Text = lsvCTPNT.SelectedItems[0].SubItems[1].Text;
                txtSL.Text = lsvCTPNT.SelectedItems[0].SubItems[3].Text;
                txtDonGia.Text = lsvCTPNT.SelectedItems[0].SubItems[4].Text;
                txtDVT.Text = lsvCTPNT.SelectedItems[0].SubItems[5].Text;
            }
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setButton(false);
            setKhoa(false);
            cbbMaPhieu.Focus();
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            if (lsvCTPNT.SelectedItems.Count > 0)
            {
                themmoi = false;
                setButton(false);
                setKhoa(false);
                slcu = txtSL.Text;
                cbbMaPhieu.Enabled = false;
                cbbTenThuoc.Enabled = false;
                cbbTenNCC.Enabled = false;
            }
            else
                MessageBox.Show("Mời chọn dòng cần sửa", "Thông báo!", MessageBoxButtons.OK);
        }

        private void bttHuy_Click(object sender, EventArgs e)
        {
            HienThiDS();
            HienThiDSPhieu();
            HienThiDSThuoc();
            HienThiDSNCC();
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
            if (lsvCTPNT.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    ct.Xoa(cbbMaPhieu.Text,cbbTenThuoc.SelectedValue.ToString(),cbbTenNCC.SelectedValue.ToString(),txtSL.Text);
                    lsvCTPNT.Items.RemoveAt(lsvCTPNT.SelectedIndices[0]);
                    ct.TinhTien(cbbMaPhieu.Text);
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
                    ct.Them(cbbMaPhieu.Text, cbbTenThuoc.SelectedValue.ToString(), cbbTenNCC.SelectedValue.ToString(), txtSL.Text,txtDonGia.Text,txtDVT.Text);
                    MessageBox.Show("Thêm mới thành công!", "Thông báo!", MessageBoxButtons.OK);
                    ct.TinhTien(cbbMaPhieu.Text);
                }

                else
                {
                    ct.CapNhat(cbbMaPhieu.Text, cbbTenThuoc.SelectedValue.ToString(), cbbTenNCC.SelectedValue.ToString(), txtSL.Text, txtDonGia.Text, txtDVT.Text,slcu);
                    MessageBox.Show("Cập nhật thành công!", "Thông báo!", MessageBoxButtons.OK);
                    ct.TinhTien(cbbMaPhieu.Text);
                }
                HienThiDS();
                HienThiDSPhieu();
                HienThiDSThuoc();
                HienThiDSNCC();
                setNull();
                setKhoa(true);
                setButton(true);
            }
        }

        public bool KTnhap()
        {
            if (cbbMaPhieu.Text.Trim() == "" || cbbTenNCC.Text.Trim() == "" || cbbTenThuoc.Text.Trim() == "" || txtSL.Text == "" || txtDonGia.Text == "" || txtDVT.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if(txtDVT.Text.Length > 10)
            {
                MessageBox.Show("Đơn vị tính chỉ nhập tối đa 10 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung(cbbMaPhieu.Text,0,cbbTenNCC.Text, 2, cbbTenThuoc.Text,1) == true && themmoi == true)
            {
                MessageBox.Show("Bạn nhập đã trùng nhà cung cấp và thuốc!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }

        private bool KTTrung(string str, int index,string str1, int index1, string str2, int index2)
        {
            for (int i = 0; i < lsvCTPNT.Items.Count; i++)
            {
                if (themmoi == true)
                {
                    if (lsvCTPNT.Items[i].SubItems[index].Text == str && lsvCTPNT.Items[i].SubItems[index1].Text == str1 && lsvCTPNT.Items[i].SubItems[index2].Text == str2)
                    {
                        return true;
                    }
                }

            }
            return false;
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbbTenThuoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt = ct.TimNCC(cbbTenThuoc.SelectedValue.ToString());

            cbbTenNCC.DataSource = dt;
            cbbTenNCC.DisplayMember = "TENNCC";
            cbbTenNCC.ValueMember = "MANCC";
        }

        private void cbbTenNCC_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cbbTenThuoc.Text == "")
            {
                MessageBox.Show("Bạn phải chọn tên thuốc trước!", "Thông báo", MessageBoxButtons.OK);
                cbbTenThuoc.Focus();
            }
        }
    }
}
