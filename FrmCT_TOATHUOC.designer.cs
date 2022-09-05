
namespace QUANLYPHONGKHAMTU
{
    partial class FrmCT_TOATHUOC
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtMaPhieuKB = new DevExpress.XtraEditors.TextEdit();
            this.txtMaPhieuKQ = new DevExpress.XtraEditors.TextEdit();
            this.txtSL = new DevExpress.XtraEditors.TextEdit();
            this.cbbTenThuoc = new System.Windows.Forms.ComboBox();
            this.cbbMaToa = new System.Windows.Forms.ComboBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lsvCT = new System.Windows.Forms.ListView();
            this.colMaToa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaPhieuKQ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaPhieuKB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenThuoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bttThem = new System.Windows.Forms.Button();
            this.bttXoa = new System.Windows.Forms.Button();
            this.bttSua = new System.Windows.Forms.Button();
            this.bttLuu = new System.Windows.Forms.Button();
            this.bttHuy = new System.Windows.Forms.Button();
            this.bttThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieuKB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieuKQ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(283, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(258, 29);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "CHI TIẾT TOA THUỐC";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtMaPhieuKB);
            this.groupControl1.Controls.Add(this.txtMaPhieuKQ);
            this.groupControl1.Controls.Add(this.txtSL);
            this.groupControl1.Controls.Add(this.cbbTenThuoc);
            this.groupControl1.Controls.Add(this.cbbMaToa);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(12, 57);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(878, 164);
            this.groupControl1.TabIndex = 1;
            // 
            // txtMaPhieuKB
            // 
            this.txtMaPhieuKB.Location = new System.Drawing.Point(544, 91);
            this.txtMaPhieuKB.Name = "txtMaPhieuKB";
            this.txtMaPhieuKB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuKB.Properties.Appearance.Options.UseFont = true;
            this.txtMaPhieuKB.Size = new System.Drawing.Size(329, 26);
            this.txtMaPhieuKB.TabIndex = 3;
            // 
            // txtMaPhieuKQ
            // 
            this.txtMaPhieuKQ.Location = new System.Drawing.Point(544, 38);
            this.txtMaPhieuKQ.Name = "txtMaPhieuKQ";
            this.txtMaPhieuKQ.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuKQ.Properties.Appearance.Options.UseFont = true;
            this.txtMaPhieuKQ.Size = new System.Drawing.Size(329, 26);
            this.txtMaPhieuKQ.TabIndex = 1;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(80, 137);
            this.txtSL.Name = "txtSL";
            this.txtSL.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Properties.Appearance.Options.UseFont = true;
            this.txtSL.Size = new System.Drawing.Size(172, 26);
            this.txtSL.TabIndex = 4;
            this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            // 
            // cbbTenThuoc
            // 
            this.cbbTenThuoc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenThuoc.FormattingEnabled = true;
            this.cbbTenThuoc.Location = new System.Drawing.Point(80, 91);
            this.cbbTenThuoc.Name = "cbbTenThuoc";
            this.cbbTenThuoc.Size = new System.Drawing.Size(331, 27);
            this.cbbTenThuoc.TabIndex = 2;
            // 
            // cbbMaToa
            // 
            this.cbbMaToa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaToa.FormattingEnabled = true;
            this.cbbMaToa.Location = new System.Drawing.Point(80, 38);
            this.cbbMaToa.Name = "cbbMaToa";
            this.cbbMaToa.Size = new System.Drawing.Size(331, 27);
            this.cbbMaToa.TabIndex = 0;
            this.cbbMaToa.SelectedIndexChanged += new System.EventHandler(this.cbbMaToa_SelectedIndexChanged);
            this.cbbMaToa.SelectionChangeCommitted += new System.EventHandler(this.cbbMaToa_SelectionChangeCommitted);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(5, 140);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(56, 18);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Số lượng";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(5, 94);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(67, 18);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Tên thuốc";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(430, 99);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(100, 18);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Mã phiếu khám";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(417, 42);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(113, 18);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Mã phiếu kết quả";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã toa";
            // 
            // lsvCT
            // 
            this.lsvCT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaToa,
            this.colMaPhieuKQ,
            this.colMaPhieuKB,
            this.colTenThuoc,
            this.colSoLuong});
            this.lsvCT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvCT.FullRowSelect = true;
            this.lsvCT.GridLines = true;
            this.lsvCT.HideSelection = false;
            this.lsvCT.Location = new System.Drawing.Point(12, 227);
            this.lsvCT.MultiSelect = false;
            this.lsvCT.Name = "lsvCT";
            this.lsvCT.Size = new System.Drawing.Size(878, 219);
            this.lsvCT.TabIndex = 2;
            this.lsvCT.TabStop = false;
            this.lsvCT.UseCompatibleStateImageBehavior = false;
            this.lsvCT.View = System.Windows.Forms.View.Details;
            this.lsvCT.SelectedIndexChanged += new System.EventHandler(this.lsvCT_SelectedIndexChanged);
            // 
            // colMaToa
            // 
            this.colMaToa.Text = "Mã toa thuốc";
            this.colMaToa.Width = 150;
            // 
            // colMaPhieuKQ
            // 
            this.colMaPhieuKQ.Text = "Mã phiếu kết quả";
            this.colMaPhieuKQ.Width = 150;
            // 
            // colMaPhieuKB
            // 
            this.colMaPhieuKB.Text = "Mã phiếu khám";
            this.colMaPhieuKB.Width = 150;
            // 
            // colTenThuoc
            // 
            this.colTenThuoc.Text = "Tên thuốc";
            this.colTenThuoc.Width = 200;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            this.colSoLuong.Width = 100;
            // 
            // bttThem
            // 
            this.bttThem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThem.Location = new System.Drawing.Point(12, 456);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(78, 51);
            this.bttThem.TabIndex = 5;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = true;
            this.bttThem.Click += new System.EventHandler(this.bttThem_Click);
            // 
            // bttXoa
            // 
            this.bttXoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXoa.Location = new System.Drawing.Point(96, 456);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(78, 51);
            this.bttXoa.TabIndex = 6;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.UseVisualStyleBackColor = true;
            this.bttXoa.Click += new System.EventHandler(this.bttXoa_Click);
            // 
            // bttSua
            // 
            this.bttSua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSua.Location = new System.Drawing.Point(180, 456);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(78, 51);
            this.bttSua.TabIndex = 7;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = true;
            this.bttSua.Click += new System.EventHandler(this.bttSua_Click);
            // 
            // bttLuu
            // 
            this.bttLuu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLuu.Location = new System.Drawing.Point(264, 456);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(78, 51);
            this.bttLuu.TabIndex = 8;
            this.bttLuu.Text = "Lưu";
            this.bttLuu.UseVisualStyleBackColor = true;
            this.bttLuu.Click += new System.EventHandler(this.bttLuu_Click);
            // 
            // bttHuy
            // 
            this.bttHuy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttHuy.Location = new System.Drawing.Point(348, 456);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(78, 51);
            this.bttHuy.TabIndex = 9;
            this.bttHuy.Text = "Hủy";
            this.bttHuy.UseVisualStyleBackColor = true;
            this.bttHuy.Click += new System.EventHandler(this.bttHuy_Click);
            // 
            // bttThoat
            // 
            this.bttThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.Location = new System.Drawing.Point(812, 456);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(78, 51);
            this.bttThoat.TabIndex = 11;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = true;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // FrmCT_TOATHUOC
            // 
            this.AcceptButton = this.bttThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bttThoat;
            this.ClientSize = new System.Drawing.Size(902, 519);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.bttSua);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.bttThem);
            this.Controls.Add(this.lsvCT);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmCT_TOATHUOC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết cung cấp thuốc";
            this.Load += new System.EventHandler(this.FrmCT_TOATHUOC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieuKB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieuKQ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaPhieuKB;
        private DevExpress.XtraEditors.TextEdit txtMaPhieuKQ;
        private DevExpress.XtraEditors.TextEdit txtSL;
        private System.Windows.Forms.ComboBox cbbTenThuoc;
        private System.Windows.Forms.ComboBox cbbMaToa;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ListView lsvCT;
        private System.Windows.Forms.ColumnHeader colMaToa;
        private System.Windows.Forms.ColumnHeader colMaPhieuKQ;
        private System.Windows.Forms.ColumnHeader colMaPhieuKB;
        private System.Windows.Forms.ColumnHeader colTenThuoc;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.Button bttThem;
        private System.Windows.Forms.Button bttXoa;
        private System.Windows.Forms.Button bttSua;
        private System.Windows.Forms.Button bttLuu;
        private System.Windows.Forms.Button bttHuy;
        private System.Windows.Forms.Button bttThoat;
    }
}