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
using Quanlyphongkham.Entities;

namespace QUANLYPHONGKHAMTU
{
    public partial class FrmCT_HoaDon : DevExpress.XtraEditors.XtraForm
    {
        public bool themmoi = false;
        CT_HoaDon ct = new CT_HoaDon();
        string matoacu = "";
        int idex;
        public FrmCT_HoaDon()
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

        public void HienThiDSHD()
        {
            DataTable dt = ct.LayDSHD();
            cbbMaHD.DataSource = dt;
            cbbMaHD.DisplayMember = "MAHD";
            cbbMaHD.ValueMember = "MAHD";
        }

        public void HienThiDSToa()
        {
            DataTable dt = ct.LayDSToa();
            cbbMaToa.DataSource = dt;
            cbbMaToa.DisplayMember = "MATOATHUOC";
            cbbMaToa.ValueMember = "MATOATHUOC";
        }

        public void HienThiDSPCLS()
        {
            DataTable dt = ct.LayDSPhieuCLS();
            cbbMaPCLS.DataSource = dt;
            cbbMaPCLS.DisplayMember = "MAPCLS";
            cbbMaPCLS.ValueMember = "MAPCLS";
        }

        public void setNull()
        {
            cbbMaHD.Text = "";
            cbbMaPCLS.Text = "";
            txtMaPKQ.Text = "";
            txtMaPKB.Text = "";
            cbbMaToa.Text = "";
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
            cbbMaHD.Enabled = !bl;
            cbbMaPCLS.Enabled = !bl;
            cbbMaToa.Enabled = !bl;
        }


        private void frmCTHD_Load(object sender, EventArgs e)
        {
            HienThiDS();
            HienThiDSHD();
            HienThiDSToa();
            HienThiDSPCLS();
            setButton(true);
            setKhoa(true);
            setNull();
            txtMaPKB.ReadOnly = true;
            txtMaPKQ.ReadOnly = true;
        }

        private void lsvCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvCT.SelectedItems.Count > 0)
            {
                cbbMaHD.Text = lsvCT.SelectedItems[0].SubItems[0].Text;
                cbbMaToa.Text = lsvCT.SelectedItems[0].SubItems[1].Text;
                cbbMaPCLS.Text = lsvCT.SelectedItems[0].SubItems[2].Text;
                txtMaPKB.Text = lsvCT.SelectedItems[0].SubItems[3].Text; 
                txtMaPKQ.Text = lsvCT.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setNull();
            setButton(false);
            setKhoa(false);
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            if (lsvCT.SelectedItems.Count > 0)
            {
                themmoi = false;
                setButton(false);
                setKhoa(false);
                cbbMaHD.Enabled = false;
                matoacu = cbbMaToa.SelectedValue.ToString();
                idex = lsvCT.SelectedIndices[0];
            }
            else
                MessageBox.Show("Mời chọn dòng cần sửa", "Thông báo!", MessageBoxButtons.OK);

        }

        private void bttHuy_Click(object sender, EventArgs e)
        {
            HienThiDS();
            HienThiDSHD();
            HienThiDSToa();
            HienThiDSPCLS();
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

        private void bttXoa_Click(object sender, EventArgs e)
        {
            if (lsvCT.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    ct.Xoa(cbbMaHD.Text, cbbMaToa.Text);
                    ct.TinhTien(cbbMaHD.Text);
                    lsvCT.Items.RemoveAt(lsvCT.SelectedIndices[0]);
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
                    ct.Them(cbbMaHD.Text,cbbMaToa.Text, cbbMaPCLS.Text,txtMaPKQ.Text,txtMaPKB.Text);
                    MessageBox.Show("Thêm mới thành công!", "Thông báo!", MessageBoxButtons.OK);
                    ct.TinhTien(cbbMaHD.Text);
                }

                else
                {
                    ct.CapNhat(cbbMaHD.Text, cbbMaToa.Text, cbbMaPCLS.Text, txtMaPKQ.Text, txtMaPKB.Text, matoacu);
                    MessageBox.Show("Cập nhật thành công!", "Thông báo!", MessageBoxButtons.OK);
                    ct.TinhTien(cbbMaHD.Text);
                }
                HienThiDS();
                HienThiDSHD();
                HienThiDSToa();
                HienThiDSPCLS();
                setNull();
                setKhoa(true);
                setButton(true);
            }

        }

        public bool KTnhap()
        {
            if (cbbMaHD.Text.Trim() == "" || cbbMaPCLS.Text.Trim() == "" || cbbMaToa.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung(cbbMaHD.Text, 0, cbbMaToa.Text, 1) == true && themmoi == true)
            {
                MessageBox.Show("Bạn nhập đã trùng mã hóa đơn và mã toa!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung_EDIT(cbbMaToa.Text, 1) == true && themmoi == false)
            {
                MessageBox.Show("Bạn nhập đã trùng mã toa!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung_EDIT(cbbMaPCLS.Text, 2) == true && themmoi == false)
            {
                MessageBox.Show("Bạn nhập đã trùng mã phiếu cận lâm sàng!", "Thông báo!", MessageBoxButtons.OK);
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

        private bool KTTrung_EDIT(string str, int index)
        {
            for (int i = 0; i < lsvCT.Items.Count; i++)
            {
                if (i != idex)
                {
                    if (lsvCT.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void cbbMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = ct.LayDSToa(cbbMaHD.SelectedValue.ToString());
            cbbMaToa.DataSource = dt;
            cbbMaToa.DisplayMember = "MATOATHUOC";
            cbbMaToa.ValueMember = "MATOATHUOC";

            DataTable dt1 = ct.LayDSPhieuCLS(cbbMaHD.SelectedValue.ToString());
            cbbMaPCLS.DataSource = dt1;
            cbbMaPCLS.DisplayMember = "MAPCLS";
            cbbMaPCLS.ValueMember = "MAPCLS";
        }

        private void cbbMaToa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = ct.LayDSPhieuKQ(cbbMaToa.SelectedValue.ToString());
            txtMaPKQ.Text = dt.Rows[0][0].ToString();
            txtMaPKB.Text = dt.Rows[0][1].ToString();
        }
    }
}