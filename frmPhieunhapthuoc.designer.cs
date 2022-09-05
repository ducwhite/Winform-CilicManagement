
namespace QUANLYPHONGKHAMTU
{
    partial class frmPhieunhapthuoc
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
            this.bttThoat = new System.Windows.Forms.Button();
            this.bttHuy = new System.Windows.Forms.Button();
            this.bttSua = new System.Windows.Forms.Button();
            this.bttLuu = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaPhieu = new DevExpress.XtraEditors.TextEdit();
            this.txtTongTien = new DevExpress.XtraEditors.TextEdit();
            this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bttXoa = new System.Windows.Forms.Button();
            this.lsvPNT = new System.Windows.Forms.ListView();
            this.colMaPhieu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayLap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTongTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bttThem = new System.Windows.Forms.Button();
            this.bttXem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bttThoat
            // 
            this.bttThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.Location = new System.Drawing.Point(840, 529);
            this.bttThoat.Margin = new System.Windows.Forms.Padding(2);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(78, 51);
            this.bttThoat.TabIndex = 12;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = true;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // bttHuy
            // 
            this.bttHuy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttHuy.Location = new System.Drawing.Point(338, 529);
            this.bttHuy.Margin = new System.Windows.Forms.Padding(2);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(78, 51);
            this.bttHuy.TabIndex = 10;
            this.bttHuy.Text = "Hủy";
            this.bttHuy.UseVisualStyleBackColor = true;
            this.bttHuy.Click += new System.EventHandler(this.bttHuy_Click);
            // 
            // bttSua
            // 
            this.bttSua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSua.Location = new System.Drawing.Point(174, 529);
            this.bttSua.Margin = new System.Windows.Forms.Padding(2);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(78, 51);
            this.bttSua.TabIndex = 8;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = true;
            this.bttSua.Click += new System.EventHandler(this.bttSua_Click);
            // 
            // bttLuu
            // 
            this.bttLuu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLuu.Location = new System.Drawing.Point(256, 529);
            this.bttLuu.Margin = new System.Windows.Forms.Padding(2);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(78, 51);
            this.bttLuu.TabIndex = 9;
            this.bttLuu.Text = "Lưu";
            this.bttLuu.UseVisualStyleBackColor = true;
            this.bttLuu.Click += new System.EventHandler(this.bttLuu_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbbMaNV);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txtMaPhieu);
            this.groupControl1.Controls.Add(this.txtTongTien);
            this.groupControl1.Controls.Add(this.dtNgayLap);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(10, 41);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(908, 139);
            this.groupControl1.TabIndex = 64;
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(555, 35);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(316, 27);
            this.cbbMaNV.TabIndex = 2;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(432, 38);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(94, 19);
            this.labelControl9.TabIndex = 20;
            this.labelControl9.Text = "Mã nhân viên";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(116, 35);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieu.Properties.Appearance.Options.UseFont = true;
            this.txtMaPhieu.Size = new System.Drawing.Size(290, 26);
            this.txtMaPhieu.TabIndex = 0;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(555, 89);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Properties.Appearance.Options.UseFont = true;
            this.txtTongTien.Size = new System.Drawing.Size(316, 26);
            this.txtTongTien.TabIndex = 3;
            this.txtTongTien.TabStop = false;
            // 
            // dtNgayLap
            // 
            this.dtNgayLap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayLap.Location = new System.Drawing.Point(116, 86);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Size = new System.Drawing.Size(290, 27);
            this.dtNgayLap.TabIndex = 1;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(432, 92);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(68, 19);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Tổng tiền";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(21, 92);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 19);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Ngày lập";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(21, 38);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mã phiếu";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(338, 8);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(247, 29);
            this.labelControl1.TabIndex = 63;
            this.labelControl1.Text = "PHIẾU NHẬP THUỐC";
            // 
            // bttXoa
            // 
            this.bttXoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXoa.Location = new System.Drawing.Point(92, 529);
            this.bttXoa.Margin = new System.Windows.Forms.Padding(2);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(78, 51);
            this.bttXoa.TabIndex = 7;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.UseVisualStyleBackColor = true;
            this.bttXoa.Click += new System.EventHandler(this.bttXoa_Click);
            // 
            // lsvPNT
            // 
            this.lsvPNT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaPhieu,
            this.colMaNV,
            this.colNgayLap,
            this.colTongTien});
            this.lsvPNT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvPNT.FullRowSelect = true;
            this.lsvPNT.GridLines = true;
            this.lsvPNT.HideSelection = false;
            this.lsvPNT.Location = new System.Drawing.Point(10, 203);
            this.lsvPNT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvPNT.Name = "lsvPNT";
            this.lsvPNT.Size = new System.Drawing.Size(908, 307);
            this.lsvPNT.TabIndex = 67;
            this.lsvPNT.UseCompatibleStateImageBehavior = false;
            this.lsvPNT.View = System.Windows.Forms.View.Details;
            this.lsvPNT.SelectedIndexChanged += new System.EventHandler(this.lsvPNT_SelectedIndexChanged);
            // 
            // colMaPhieu
            // 
            this.colMaPhieu.Text = "Mã phiếu";
            this.colMaPhieu.Width = 100;
            // 
            // colMaNV
            // 
            this.colMaNV.Text = "Mã NV";
            this.colMaNV.Width = 100;
            // 
            // colNgayLap
            // 
            this.colNgayLap.Text = "Ngày Lập";
            this.colNgayLap.Width = 100;
            // 
            // colTongTien
            // 
            this.colTongTien.Text = "Tổng tiền";
            this.colTongTien.Width = 100;
            // 
            // bttThem
            // 
            this.bttThem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThem.Location = new System.Drawing.Point(10, 529);
            this.bttThem.Margin = new System.Windows.Forms.Padding(2);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(78, 51);
            this.bttThem.TabIndex = 6;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = true;
            this.bttThem.Click += new System.EventHandler(this.bttThem_Click);
            // 
            // bttXem
            // 
            this.bttXem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXem.Location = new System.Drawing.Point(420, 529);
            this.bttXem.Margin = new System.Windows.Forms.Padding(2);
            this.bttXem.Name = "bttXem";
            this.bttXem.Size = new System.Drawing.Size(78, 51);
            this.bttXem.TabIndex = 11;
            this.bttXem.Text = "Xem CT";
            this.bttXem.UseVisualStyleBackColor = true;
            this.bttXem.Click += new System.EventHandler(this.bttXem_Click);
            // 
            // frmPhieunhapthuoc
            // 
            this.AcceptButton = this.bttThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bttThoat;
            this.ClientSize = new System.Drawing.Size(936, 592);
            this.Controls.Add(this.bttXem);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.bttSua);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.lsvPNT);
            this.Controls.Add(this.bttThem);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPhieunhapthuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu nhập thuốc";
            this.Load += new System.EventHandler(this.frmPhieunhapthuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.Button bttHuy;
        private System.Windows.Forms.Button bttSua;
        private System.Windows.Forms.Button bttLuu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button bttXoa;
        private System.Windows.Forms.ListView lsvPNT;
        private System.Windows.Forms.Button bttThem;
        private System.Windows.Forms.DateTimePicker dtNgayLap;
        private DevExpress.XtraEditors.TextEdit txtMaPhieu;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.ColumnHeader colMaPhieu;
        private System.Windows.Forms.ColumnHeader colNgayLap;
        private System.Windows.Forms.ColumnHeader colMaNV;
        private System.Windows.Forms.ColumnHeader colTongTien;
        private DevExpress.XtraEditors.TextEdit txtTongTien;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.Button bttXem;
        private System.Windows.Forms.ComboBox cbbMaNV;
    }
}