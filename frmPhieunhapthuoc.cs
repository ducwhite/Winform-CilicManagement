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
    public partial class frmPhieunhapthuoc : DevExpress.XtraEditors.XtraForm
    {
        PhieuNT pnt = new PhieuNT();
        bool themmoi = true;
        public frmPhieunhapthuoc()
        {
            InitializeComponent();
        }
        public void HienThiDS()
        {
            lsvPNT.Items.Clear();
            DataTable dt = pnt.LayDS();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvPNT.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
            }
        }

        public void HienThiNV()
        {
            DataTable dt = pnt.LayDSNV();

            cbbMaNV.DataSource = dt;
            cbbMaNV.DisplayMember = "MANV";
            cbbMaNV.ValueMember = "MANV";
        }

        public void setNull()
        {
            cbbMaNV.Text = "";
            txtMaPhieu.Text = "";
            dtNgayLap.Text = "";
            txtTongTien.Text = "";
        }

        void setButton(bool bl)
        {
            bttThem.Enabled = bl;
            bttXoa.Enabled = bl;
            bttSua.Enabled = bl;
            bttXem.Enabled = bl;
            bttThoat.Enabled = bl;
            bttLuu.Enabled = !bl;
            bttHuy.Enabled = !bl;
        }

        void setKhoa(bool bl)
        {
            txtMaPhieu.ReadOnly = bl;
            cbbMaNV.Enabled = !bl;
            dtNgayLap.Enabled = !bl;
            txtTongTien.ReadOnly = true;
        }
        private void frmPhieunhapthuoc_Load(object sender, EventArgs e)
        {
            HienThiDS();
            HienThiNV();
            setButton(true);
            setKhoa(true);
            setNull();
        }

        private void lsvPNT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvPNT.SelectedItems.Count > 0)
            {
                txtMaPhieu.Text = lsvPNT.SelectedItems[0].SubItems[0].Text;
                cbbMaNV.Text = lsvPNT.SelectedItems[0].SubItems[1].Text;
                dtNgayLap.Text = lsvPNT.SelectedItems[0].SubItems[2].Text;
                txtTongTien.Text = lsvPNT.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setButton(false);
            setKhoa(false);
            txtTongTien.Text = "0";
            txtMaPhieu.Focus();
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            if (lsvPNT.SelectedItems.Count > 0)
            {
                themmoi = false;
                setButton(false);
                setKhoa(false);
                txtMaPhieu.ReadOnly = true;
            }
            else
                MessageBox.Show("Mời chọn dòng cần sửa", "Thông báo!", MessageBoxButtons.OK);
        }

        private void bttHuy_Click(object sender, EventArgs e)
        {
            HienThiDS();
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
            if (lsvPNT.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    pnt.Xoa(lsvPNT.SelectedItems[0].SubItems[0].Text);
                    lsvPNT.Items.RemoveAt(lsvPNT.SelectedIndices[0]);
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
                string ngay = String.Format("{0:MM/dd/yyyy}",dtNgayLap.Value);

                if (themmoi == true)
                {
                    pnt.Them(txtMaPhieu.Text,cbbMaNV.Text,ngay,txtTongTien.Text);
                    MessageBox.Show("Thêm mới thành công!", "Thông báo!", MessageBoxButtons.OK);
                }

                else
                {
                    pnt.CapNhat(txtMaPhieu.Text, cbbMaNV.Text, ngay);
                    MessageBox.Show("Cập nhật thành công!", "Thông báo!", MessageBoxButtons.OK);
                }
                HienThiDS();
                HienThiNV();
                setNull();
                setKhoa(true);
                setButton(true);
            }
        }

        public bool KTnhap()
        {
            if (txtMaPhieu.Text.Trim() == "" || cbbMaNV.Text.Trim() == "" || dtNgayLap.Text == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (txtMaPhieu.Text.Length != 6)
            {
                MessageBox.Show("Mã phiếu phải có đúng 6 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (cbbMaNV.Text.Length != 5)
            {
                MessageBox.Show("Mã nhân viên phải có đúng 5 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if(dtNgayLap.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày lập không quá hiện tại!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung(txtMaPhieu.Text,0) == true && themmoi == true)
            {
                MessageBox.Show("Bạn nhập đã trùng mã phiếu!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }

        private bool KTTrung(string str, int index)
        {
            for (int i = 0; i < lsvPNT.Items.Count; i++)
            {
                if (lsvPNT.Items[i].SubItems[index].Text == str)
                {
                    return true;
                }
            }
            return false;
        }

        private void bttXem_Click(object sender, EventArgs e)
        {
            var frm = new FrmCTPhieuNT();
            frm.Show();
        }
    }
}