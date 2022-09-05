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
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        ConnectToSQL con = new ConnectToSQL();
        public frmDangNhap()
        {
            InitializeComponent();
        }



        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Xmas 2008 Blue";
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = con.GetData("select * from TAIKHOAN where TENTK = '"+textEdit1.Text+"' and MATKHAUTK ='"+textEdit2.Text +"'");
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain f = new frmMain(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Thông tin tài khoản không chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            FrmDangKy f = new FrmDangKy();
            this.Hide();
            f.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
           skins();
        }
    }
}