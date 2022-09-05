using DevExpress.Utils.Serializing;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraSplashScreen;
using QUANLYPHONGKHAMTU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls.Ribbon;
using System.Windows.Forms;

namespace Quanlyphongkham
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
       // public string tendangnhap = "", matkhau = "", quyen = "";

        public string tendangnhap { get; set; } = "";
        public string matkhau { get; set; } = "";
        public string quyen { get; set; } = "";


        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(string tendangnhap, string matkhau, string quyen)
        {
            InitializeComponent();
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            this.quyen = quyen;

        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            barButtonItem1.Caption = "Quyền: "+ quyen;
            ribbonPageGroup1.Text = "Xin chào: " + tendangnhap;
            skins();

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

        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Xmas 2008 Blue";
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                showLoadingForm();
                frmDangNhap f = new frmDangNhap();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                return;
            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
                showLoadingForm();
                frmPhieukhambenh f = new frmPhieukhambenh();
                f.MdiParent = this;
                f.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            if (quyen == "Admin")
            {
                frmDanhSachTaiKhoan f = new frmDanhSachTaiKhoan();
                f.MdiParent = this;
                f.Show();
                frmMain_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dockPanel3_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();

            if (quyen == "Admin")
            {
                frmDoiMatKhau f = new frmDoiMatKhau();
                f.MdiParent = this;
                f.Show();
                frmMain_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void skinDropDownButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            frmPhieunhapthuoc f = new frmPhieunhapthuoc();
            f.MdiParent = this;
            f.Show();
            frmMain_Load(sender, e); 
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmDMLoaiThuoc();
            frm.Show();
        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmchucvu();
            frm.Show();
        }

        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmDantoc();
            frm.Show();
        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmLoaikham();
            frm.Show();
        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmPhongKham();
            frm.Show();
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            frmphieuketqua f = new frmphieuketqua();
            f.MdiParent = this;
            f.Show();
            frmMain_Load(sender, e);
        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            frmPhieucanLS f = new frmPhieucanLS();
            f.MdiParent = this;
            f.Show();
            frmMain_Load(sender, e);
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            if (quyen == "Admin" || quyen == "Nhanvien")
            {
                frmtimkiemnv f = new frmtimkiemnv();
                f.MdiParent = this;
                f.Show();
                frmMain_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            if (quyen == "Admin" || quyen == "Nhanvien")
            {
                frmtiemkiembacsy f = new frmtiemkiembacsy();
                f.MdiParent = this;
                f.Show();
                frmMain_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            if (quyen == "Admin" || quyen == "Nhanvien")
            {
                frmtiemkiembenhnhan f = new frmtiemkiembenhnhan();
                f.MdiParent = this;
                f.Show();
                frmMain_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                showLoadingForm();
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();

            if (quyen == "Admin" || quyen == "Nhanvien")
            {
                frmtimkiemthuoc f = new frmtimkiemthuoc();
                f.MdiParent = this;
                f.Show();
                frmMain_Load(sender, e); 
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void navBarControl3_Click(object sender, EventArgs e)
        {

        }

        private void dockPanel3_Click_1(object sender, EventArgs e)
        {

        }

        private void barButtonItem31_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            frmDSBN f = new frmDSBN();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem32_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            frmbacsy f = new frmbacsy();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem33_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            FrmDanhMucThuoc f = new FrmDanhMucThuoc();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem34_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            FrmDMLoaiThuoc f = new FrmDMLoaiThuoc();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem44_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            frmDanhmucnhacungcap f = new frmDanhmucnhacungcap();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem36_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            frmDantoc f = new frmDantoc();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem37_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            frmKhoadieutri f = new frmKhoadieutri();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem38_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            frmLoaikham f = new frmLoaikham();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem39_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            frmchucvu f = new frmchucvu();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem43_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            frmDichVu f = new frmDichVu();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            frmHoadonTT f = new frmHoadonTT();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            frmBAOCAODOANHTHU f = new frmBAOCAODOANHTHU();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem45_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            FrmCT_HoaDon f = new FrmCT_HoaDon();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem29_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Chức năng đang cập nhật...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void barButtonItem47_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            frmNV f = new frmNV();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem46_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            FrmCTPhieuNT f = new FrmCTPhieuNT();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem48_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            FrmDMLoaiThuoc f = new FrmDMLoaiThuoc();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem50_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            frmPhongKham f = new frmPhongKham();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem49_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            FrmToaThuoc f = new FrmToaThuoc();
            f.MdiParent = this;
            f.Show();
        }
        
        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem51_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            FrmPhongCho f = new FrmPhongCho();
            f.MdiParent = this;
            f.Show();
        }
    }
}