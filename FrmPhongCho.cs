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
using QUANLYPHONGKHAMTU;
namespace Quanlyphongkham
{
    public partial class FrmPhongCho : DevExpress.XtraEditors.XtraForm
    {
        PhongCho pc = new PhongCho();
        public FrmPhongCho()
        {
            InitializeComponent();
        }

        public void HienThiDS(int index)
        {
            string ngay = String.Format("{0:MM/dd/yyyy}", dtNgayLap.Value);
            lsvCT.Items.Clear();
            DataTable dt = pc.LayDSPhieuKB(cbbTenPK.SelectedValue.ToString(), index, ngay);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvCT.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                if (dt.Rows[i][3].ToString()=="True")
                {
                    lvi.SubItems.Add("Đã khám");
                }
                else
                {
                    lvi.SubItems.Add("Chưa khám");
                }
            }
        }

        public void HienThiDSPK()
        {
            DataTable dt = pc.LayDSPK();
            cbbTenPK.DataSource = dt;
            cbbTenPK.DisplayMember = "TENPK";
            cbbTenPK.ValueMember = "MAPK";
        }

        private void FrmPhongCho_Load(object sender, EventArgs e)
        {
            HienThiDSPK();
            cbbTenPK.SelectedIndex = 0;
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Yes để thoát !", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void radbttTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (radbttTatCa.Checked == true)
            {
                HienThiDS(0);
                string s = string.Format("{0}", lsvCT.Items.Count);
                lbT.Text = s;
            }
        }

        private void radbttDaKham_CheckedChanged(object sender, EventArgs e)
        {
            if (radbttDaKham.Checked == true)
            {
                HienThiDS(2);
                string s = string.Format("{0}", lsvCT.Items.Count);
                lbT.Text = s;
            }
        }

        private void radbttChuaKham_CheckedChanged(object sender, EventArgs e)
        {
            if (radbttChuaKham.Checked == true)
            {
                HienThiDS(1);
                string s = string.Format("{0}", lsvCT.Items.Count);
                lbT.Text = s;
            }
        }

        private void bttXem_Click(object sender, EventArgs e)
        {
            if (lsvCT.SelectedItems.Count > 0)
            {
                frmPhieukhambenh frm = new frmPhieukhambenh();
                frm.timkiem = lsvCT.SelectedItems[0].SubItems[0].Text;
                frm.Show();

            }
            else
                MessageBox.Show("Mời chọn dòng cần xem", "Thông báo!", MessageBoxButtons.OK);
        }

        private void lbT_Click(object sender, EventArgs e)
        {

        }
    }
}