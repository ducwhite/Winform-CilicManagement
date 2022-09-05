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
using System.Data.SqlClient;
using Quanlyphongkham.model;
using DevExpress.XtraSplashScreen;
using System.Threading;

namespace Quanlyphongkham
{
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        ConnectToSQL con = new ConnectToSQL();
        Model1 dbcontext = new Model1();

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-1A68DCF;Initial Catalog=QUANLYPHONGKHAM;Integrated Security=True");
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from TAIKHOAN where TENTK = N'" + comboBox1.GetItemText(this.comboBox1.SelectedItem) + "' and MATKHAUTK =N'" + txtmkcu.Text + "'",cn);
            da.Fill(dt);
            errorProvider1.Clear();
            if (dt.Rows[0][0].ToString()=="1")

            {
                if (txtmkmoi.Text==txtxnmk.Text)

                {
                    if (txtmkmoi.Text.Length>=6)
                    {
                        showLoadingForm();
                        SqlDataAdapter da1 = new SqlDataAdapter("update TAIKHOAN set MATKHAUTK=N'" + txtmkmoi.Text + "'where TENTK=N'" + comboBox1.GetItemText(this.comboBox1.SelectedItem) + "'and MATKHAUTK=N'" + txtmkcu.Text + "'", cn);
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);
                        MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearText();

                    }
                    else
                    {
                        errorProvider1.SetError(txtmkmoi, "Độ dài mật khẩu không đủ!");
                    }

                }
                else
                {
                    errorProvider1.SetError(txtmkmoi, "Bạn chưa điền mật khẩu!");
                    errorProvider1.SetError(txtxnmk, "Mật khẩu nhập lại chưa đúng!");
                }
            }

            else
            {
                errorProvider1.SetError(comboBox1, "tên người dùng không đúng");
                errorProvider1.SetError(txtmkcu, "Mật khẩu cũ không đúng!");
            } 
        }
   

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            List<TAIKHOAN> list = dbcontext.TAIKHOANs.ToList();
            FillDataToComboBox(list);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn hủy?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
            }
            else
            {
                return;
            }
        }
        public void FillDataToComboBox(List<TAIKHOAN> tAIKHOANs)

        {
            comboBox1.DataSource = tAIKHOANs;
            comboBox1.DisplayMember = "TENTK";
        }

        public void clearText()
        {
            txtmkcu.Text = "";
            txtmkmoi.Text = "";
            txtxnmk.Text = "";
        }
        public void showLoadingForm()
        {
            SplashScreenManager.ShowForm(this, typeof(frmLoading), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("PHÒNG KHÁM HKDD...");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(2);
            }
            SplashScreenManager.CloseForm();
        }
    }
}