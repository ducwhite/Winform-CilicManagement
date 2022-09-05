
namespace Quanlyphongkham
{
    partial class frmDanhSachTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.TenTK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MatKhau = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quyen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TenTK,
            this.MatKhau,
            this.Quyen});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(92, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(364, 158);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // TenTK
            // 
            this.TenTK.Text = "Tên tài khoản";
            this.TenTK.Width = 120;
            // 
            // MatKhau
            // 
            this.MatKhau.Text = "Mật khẩu";
            this.MatKhau.Width = 120;
            // 
            // Quyen
            // 
            this.Quyen.Text = "Quyền";
            this.Quyen.Width = 120;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(102, 12);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(288, 29);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "DANH SÁCH TÀI KHOẢN";
            // 
            // frmDanhSachTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 271);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.listView1);
            this.Name = "frmDanhSachTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách tài khoản";
            this.Load += new System.EventHandler(this.frmDanhSachTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader TenTK;
        private System.Windows.Forms.ColumnHeader MatKhau;
        private System.Windows.Forms.ColumnHeader Quyen;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}