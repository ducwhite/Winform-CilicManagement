using DevExpress.XtraEditors;
using Quanlyphongkham.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlyphongkham
{
    public partial class FrmDangKy : DevExpress.XtraEditors.XtraForm
    {
        ConnectToSQL con = new ConnectToSQL();
        Model1 dbcontext = new Model1();
        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn hủy?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr==DialogResult.Yes)
            {
                frmDangNhap f = new frmDangNhap();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                return;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            if(textEdit3.Text == "HKDD")
            {
                if (textEdit2.Text.Length >= 6)
                {
                    dt = con.GetData("insert into TAIKHOAN values ('" + textEdit1.Text + "','" + textEdit2.Text + "','" + comboBox1.GetItemText(this.comboBox1.SelectedItem) + "')");
                    DialogResult dr = MessageBox.Show("Bạn đã đăng ký thành công? Đăng nhập ngay?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        frmDangNhap f = new frmDangNhap();
                        this.Hide();
                        f.ShowDialog();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    errorProvider1.SetError(textEdit2, "Độ dài mật khẩu không đủ!");
                }

            }
            else
            {
                errorProvider1.SetError(textEdit3, "Mã xác nhận không đúng!");
            }      
        }

        private void FrmDangKy_Load(object sender, EventArgs e)
        {
            List<PHANQUYEN> list = dbcontext.PHANQUYENs.ToList();
            FillDataToComboBox(list);
        }

        public void FillDataToComboBox(List<PHANQUYEN> pHANQUYENs)

        {
            comboBox1.DataSource = pHANQUYENs;
            comboBox1.DisplayMember = "QUYENTK";

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}