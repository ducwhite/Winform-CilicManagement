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
    public partial class FrmCT_CungCapThuoc : DevExpress.XtraEditors.XtraForm
    {
        bool themmoi = false;
        CT_CungCapThuoc ct = new CT_CungCapThuoc();
        string mathuoccu = "";
        int idex;
        public FrmCT_CungCapThuoc()
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
            }
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
            cbbTenNCC.Text = "";
            cbbTenThuoc.Text = "";
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
            cbbTenNCC.Enabled = !bl;
            cbbTenThuoc.Enabled = !bl;
        }

        private void FrmCT_CungCapThuoc_Load(object sender, EventArgs e)
        {
            HienThiDS();
            HienThiDSThuoc();
            HienThiDSNCC();
            setButton(true);
            setKhoa(true);
            setNull();
        }

        private void lsvCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvCT.SelectedItems.Count > 0)
            {
                cbbTenNCC.Text = lsvCT.SelectedItems[0].SubItems[0].Text;
                cbbTenThuoc.Text = lsvCT.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setButton(false);
            setKhoa(false);
            cbbTenNCC.Focus();
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            if (lsvCT.SelectedItems.Count > 0)
            {
                themmoi = false;
                setButton(false);
                setKhoa(false);
                mathuoccu = cbbTenThuoc.SelectedValue.ToString();
                cbbTenNCC.Enabled = false;
                idex = lsvCT.SelectedIndices[0];
            }
            else
                MessageBox.Show("Mời chọn dòng cần sửa", "Thông báo!", MessageBoxButtons.OK);
        }

        private void bttHuy_Click(object sender, EventArgs e)
        {
            HienThiDS();
            HienThiDSThuoc();
            HienThiDSNCC();
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
                    ct.Xoa(cbbTenThuoc.SelectedValue.ToString(), cbbTenNCC.SelectedValue.ToString());
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
                    ct.Them(cbbTenThuoc.SelectedValue.ToString(), cbbTenNCC.SelectedValue.ToString());
                    MessageBox.Show("Thêm mới thành công!", "Thông báo!", MessageBoxButtons.OK);
                }

                else
                {
                    ct.CapNhat(cbbTenThuoc.SelectedValue.ToString(), cbbTenNCC.SelectedValue.ToString(),mathuoccu);
                    MessageBox.Show("Cập nhật thành công!", "Thông báo!", MessageBoxButtons.OK);
                }
                HienThiDS();
                HienThiDSThuoc();
                HienThiDSNCC();
                setNull();
                setKhoa(true);
                setButton(true);
            }
        }
        public bool KTnhap()
        {
            if (cbbTenNCC.Text.Trim() == "" || cbbTenThuoc.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung(cbbTenNCC.Text, 0, cbbTenThuoc.Text, 1) == true && themmoi == true)
            {
                MessageBox.Show("Bạn nhập đã trùng nhà cung cấp và thuốc!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung_EDIT(cbbTenThuoc.Text, 1) == true && themmoi == false)
            {
                MessageBox.Show("Bạn nhập đã trùng tên thuốc!", "Thông báo!", MessageBoxButtons.OK);
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
    }
}