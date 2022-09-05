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
using Quanlyphongkham;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using System.Threading;

namespace QUANLYPHONGKHAMTU
{
    public partial class FrmToaThuoc : DevExpress.XtraEditors.XtraForm
    {
        bool themmoi = true;
        ToaThuoc t = new ToaThuoc();
        public FrmToaThuoc()
        {
            InitializeComponent();
        }
        public void HienThiDS()
        {
            lsvTT.Items.Clear();
            DataTable dt = t.LayDS();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvTT.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
            }
        }

        public void HienThiPhieuKQ()
        {
            DataTable dt = t.LayDSPhieuKQ();

            cbbMaPhieuKQ.DataSource = dt;
            cbbMaPhieuKQ.DisplayMember = "MAPHIEUKQ";
            cbbMaPhieuKQ.ValueMember = "MAPHIEUKB";
        }

        public void setNull()
        {
            txtMaToa.Text = "";
            cbbMaPhieuKQ.Text = "";
            txtMaPhieuKB.Text = "";
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
            txtMaToa.ReadOnly = bl;
            cbbMaPhieuKQ.Enabled = !bl;
            dtNgayLap.Enabled = !bl;

        }
        private void FrmToaThuoc_Load(object sender, EventArgs e)
        {
            txtTongTien.ReadOnly = true;
            txtMaPhieuKB.ReadOnly = true;
            HienThiDS();
            HienThiPhieuKQ();
            setButton(true);
            setKhoa(true);
            setNull();
        }

        private void lsvTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvTT.SelectedItems.Count > 0)
            {
                txtMaToa.Text = lsvTT.SelectedItems[0].SubItems[0].Text;
                cbbMaPhieuKQ.Text = lsvTT.SelectedItems[0].SubItems[1].Text;
                txtMaPhieuKB.Text = lsvTT.SelectedItems[0].SubItems[2].Text;
                dtNgayLap.Text = lsvTT.SelectedItems[0].SubItems[3].Text;
                txtTongTien.Text = lsvTT.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setButton(false);
            setKhoa(false);
            txtTongTien.Text = "0";
            txtMaToa.Focus();
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            if (lsvTT.SelectedItems.Count > 0)
            {
                themmoi = false;
                setButton(false);
                setKhoa(false);
                txtMaToa.ReadOnly = true;
                cbbMaPhieuKQ.Enabled = false;
                dtNgayLap.Focus();
            }
            else
                MessageBox.Show("Mời chọn dòng cần sửa", "Thông báo!", MessageBoxButtons.OK);
        }

        private void bttHuy_Click(object sender, EventArgs e)
        {
            HienThiDS();
            HienThiPhieuKQ();
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
            if (lsvTT.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    t.Xoa(lsvTT.SelectedItems[0].SubItems[0].Text);
                    lsvTT.Items.RemoveAt(lsvTT.SelectedIndices[0]);
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
                string ngay = String.Format("{0:MM/dd/yyyy}", dtNgayLap.Value);

                if (themmoi == true)
                {
                    t.Them(txtMaToa.Text, cbbMaPhieuKQ.Text,txtMaPhieuKB.Text, ngay, txtTongTien.Text);
                    MessageBox.Show("Thêm mới thành công!", "Thông báo!", MessageBoxButtons.OK);
                }

                else
                {
                    t.CapNhat(txtMaToa.Text,ngay);
                    MessageBox.Show("Cập nhật thành công!", "Thông báo!", MessageBoxButtons.OK);
                }
                HienThiDS();
                HienThiPhieuKQ();
                setNull();
                setKhoa(true);
                setButton(true);
            }
        }

        public bool KTnhap()
        {
            if (txtMaToa.Text.Trim() == "" || cbbMaPhieuKQ.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (txtMaToa.Text.Length != 5)
            {
                MessageBox.Show("Mã toa phải có đúng 5 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if(dtNgayLap.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày lập không quá hiện tại!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung(txtMaToa.Text, 0,cbbMaPhieuKQ.Text,1) == true && themmoi == true)
            {
                MessageBox.Show("Bạn nhập đã trùng mã toa và mã phiếu kết quả!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }

        private bool KTTrung(string str, int index, string str1, int index1)
        {
            for (int i = 0; i < lsvTT.Items.Count; i++)
            {
                if (themmoi == true)
                {
                    if (lsvTT.Items[i].SubItems[index].Text == str && lsvTT.Items[i].SubItems[index1].Text == str1)
                    {
                        return true;
                    }
                }

            }
            return false;
        }
        private void cbbMaPhieuKQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaPhieuKB.Text = cbbMaPhieuKQ.SelectedValue.ToString();
        }

        private void bttXem_Click(object sender, EventArgs e)
        {
            FrmCT_TOATHUOC frm = new FrmCT_TOATHUOC();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showLoadingForm();
            XtraReport1 rp = new XtraReport1();
            rp.FilterString = "[MATOATHUOC]='" + txtMaToa.Text + "'";
            rp.CreateDocument();
            rp.ShowPreviewDialog();
        }

        public void showLoadingForm()
        {
            SplashScreenManager.ShowForm(this, typeof(frmLoading), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("PHÒNG KHÁM HKDD...");
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(1);
            }
            SplashScreenManager.CloseForm();
        }
    }
}