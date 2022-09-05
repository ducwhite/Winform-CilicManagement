
namespace QUANLYPHONGKHAMTU
{
    partial class FrmCT_HoaDon
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
            this.colMaPhieuKB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbbMaToa = new System.Windows.Forms.ComboBox();
            this.cbbMaHD = new System.Windows.Forms.ComboBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.bttLuu = new System.Windows.Forms.Button();
            this.bttSua = new System.Windows.Forms.Button();
            this.bttXoa = new System.Windows.Forms.Button();
            this.bttThem = new System.Windows.Forms.Button();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.colMaPKQ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.bttThoat = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.colMaPCLS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaToa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bttHuy = new System.Windows.Forms.Button();
            this.lsvCT = new System.Windows.Forms.ListView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtMaPKQ = new DevExpress.XtraEditors.TextEdit();
            this.txtMaPKB = new DevExpress.XtraEditors.TextEdit();
            this.cbbMaPCLS = new System.Windows.Forms.ComboBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPKQ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPKB.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // colMaPhieuKB
            // 
            this.colMaPhieuKB.Text = "Mã Phiếu khám bệnh";
            this.colMaPhieuKB.Width = 200;
            // 
            // cbbMaToa
            // 
            this.cbbMaToa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaToa.FormattingEnabled = true;
            this.cbbMaToa.Location = new System.Drawing.Point(107, 78);
            this.cbbMaToa.Name = "cbbMaToa";
            this.cbbMaToa.Size = new System.Drawing.Size(261, 27);
            this.cbbMaToa.TabIndex = 1;
            this.cbbMaToa.SelectedIndexChanged += new System.EventHandler(this.cbbMaToa_SelectedIndexChanged);
            // 
            // cbbMaHD
            // 
            this.cbbMaHD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaHD.FormattingEnabled = true;
            this.cbbMaHD.Location = new System.Drawing.Point(107, 27);
            this.cbbMaHD.Name = "cbbMaHD";
            this.cbbMaHD.Size = new System.Drawing.Size(261, 27);
            this.cbbMaHD.TabIndex = 0;
            this.cbbMaHD.SelectedIndexChanged += new System.EventHandler(this.cbbMaHD_SelectedIndexChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(398, 82);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(123, 19);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Mã phiếu kết quả:";
            // 
            // bttLuu
            // 
            this.bttLuu.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLuu.Location = new System.Drawing.Point(298, 428);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(87, 41);
            this.bttLuu.TabIndex = 10;
            this.bttLuu.Text = "Lưu";
            this.bttLuu.UseVisualStyleBackColor = true;
            this.bttLuu.Click += new System.EventHandler(this.bttLuu_Click);
            // 
            // bttSua
            // 
            this.bttSua.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSua.Location = new System.Drawing.Point(205, 428);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(87, 41);
            this.bttSua.TabIndex = 9;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = true;
            this.bttSua.Click += new System.EventHandler(this.bttSua_Click);
            // 
            // bttXoa
            // 
            this.bttXoa.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXoa.Location = new System.Drawing.Point(111, 428);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(87, 41);
            this.bttXoa.TabIndex = 8;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.UseVisualStyleBackColor = true;
            this.bttXoa.Click += new System.EventHandler(this.bttXoa_Click);
            // 
            // bttThem
            // 
            this.bttThem.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThem.Location = new System.Drawing.Point(17, 428);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(87, 41);
            this.bttThem.TabIndex = 7;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = true;
            this.bttThem.Click += new System.EventHandler(this.bttThem_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(5, 135);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 19);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Mã PCLS:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(398, 30);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(146, 19);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Mã phiếu khám bệnh:";
            // 
            // colMaPKQ
            // 
            this.colMaPKQ.Text = "Mã Phiếu kết quả";
            this.colMaPKQ.Width = 200;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 82);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mã toa thuốc:";
            // 
            // bttThoat
            // 
            this.bttThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttThoat.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.Location = new System.Drawing.Point(759, 425);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(102, 41);
            this.bttThoat.TabIndex = 12;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = true;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã hóa đơn:";
            // 
            // colMaPCLS
            // 
            this.colMaPCLS.Text = "Mã phiếu cận lâm sàng";
            this.colMaPCLS.Width = 300;
            // 
            // colMaToa
            // 
            this.colMaToa.Text = "Mã toa thuốc";
            this.colMaToa.Width = 250;
            // 
            // colMaHD
            // 
            this.colMaHD.Text = "Mã hóa đơn";
            this.colMaHD.Width = 200;
            // 
            // bttHuy
            // 
            this.bttHuy.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttHuy.Location = new System.Drawing.Point(392, 428);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(87, 41);
            this.bttHuy.TabIndex = 11;
            this.bttHuy.Text = "Hủy";
            this.bttHuy.UseVisualStyleBackColor = true;
            this.bttHuy.Click += new System.EventHandler(this.bttHuy_Click);
            // 
            // lsvCT
            // 
            this.lsvCT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHD,
            this.colMaToa,
            this.colMaPCLS,
            this.colMaPhieuKB,
            this.colMaPKQ});
            this.lsvCT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvCT.FullRowSelect = true;
            this.lsvCT.GridLines = true;
            this.lsvCT.HideSelection = false;
            this.lsvCT.Location = new System.Drawing.Point(17, 209);
            this.lsvCT.MultiSelect = false;
            this.lsvCT.Name = "lsvCT";
            this.lsvCT.Size = new System.Drawing.Size(844, 198);
            this.lsvCT.TabIndex = 13;
            this.lsvCT.TabStop = false;
            this.lsvCT.UseCompatibleStateImageBehavior = false;
            this.lsvCT.View = System.Windows.Forms.View.Details;
            this.lsvCT.SelectedIndexChanged += new System.EventHandler(this.lsvCT_SelectedIndexChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtMaPKQ);
            this.groupControl1.Controls.Add(this.txtMaPKB);
            this.groupControl1.Controls.Add(this.cbbMaPCLS);
            this.groupControl1.Controls.Add(this.cbbMaToa);
            this.groupControl1.Controls.Add(this.cbbMaHD);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(17, 44);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(844, 159);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin hóa đơn";
            // 
            // txtMaPKQ
            // 
            this.txtMaPKQ.Location = new System.Drawing.Point(550, 78);
            this.txtMaPKQ.Name = "txtMaPKQ";
            this.txtMaPKQ.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPKQ.Properties.Appearance.Options.UseFont = true;
            this.txtMaPKQ.Size = new System.Drawing.Size(289, 26);
            this.txtMaPKQ.TabIndex = 4;
            // 
            // txtMaPKB
            // 
            this.txtMaPKB.Location = new System.Drawing.Point(550, 27);
            this.txtMaPKB.Name = "txtMaPKB";
            this.txtMaPKB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPKB.Properties.Appearance.Options.UseFont = true;
            this.txtMaPKB.Size = new System.Drawing.Size(289, 26);
            this.txtMaPKB.TabIndex = 3;
            // 
            // cbbMaPCLS
            // 
            this.cbbMaPCLS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaPCLS.FormattingEnabled = true;
            this.cbbMaPCLS.Location = new System.Drawing.Point(107, 127);
            this.cbbMaPCLS.Name = "cbbMaPCLS";
            this.cbbMaPCLS.Size = new System.Drawing.Size(261, 27);
            this.cbbMaPCLS.TabIndex = 2;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(327, 10);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(234, 29);
            this.labelControl7.TabIndex = 66;
            this.labelControl7.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // FrmCT_HoaDon
            // 
            this.AcceptButton = this.bttThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bttThoat;
            this.ClientSize = new System.Drawing.Size(873, 478);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.bttSua);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.bttThem);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.lsvCT);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCT_HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết hóa đơn";
            this.Load += new System.EventHandler(this.frmCTHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPKQ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPKB.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader colMaPhieuKB;
        private System.Windows.Forms.ComboBox cbbMaToa;
        private System.Windows.Forms.ComboBox cbbMaHD;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.Button bttLuu;
        private System.Windows.Forms.Button bttSua;
        private System.Windows.Forms.Button bttXoa;
        private System.Windows.Forms.Button bttThem;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ColumnHeader colMaPKQ;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Button bttThoat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ColumnHeader colMaPCLS;
        private System.Windows.Forms.ColumnHeader colMaToa;
        private System.Windows.Forms.ColumnHeader colMaHD;
        private System.Windows.Forms.Button bttHuy;
        private System.Windows.Forms.ListView lsvCT;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cbbMaPCLS;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtMaPKQ;
        private DevExpress.XtraEditors.TextEdit txtMaPKB;
    }
}