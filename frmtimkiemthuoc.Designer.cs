
namespace Quanlyphongkham
{
    partial class frmtimkiemthuoc
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
            this.lsvThuoc = new System.Windows.Forms.ListView();
            this.colMaSo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenThuoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonViTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenLoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbbTenL = new System.Windows.Forms.ComboBox();
            this.txtMaSo = new DevExpress.XtraEditors.TextEdit();
            this.txtTenThuoc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bttThoat = new System.Windows.Forms.Button();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenThuoc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvThuoc
            // 
            this.lsvThuoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSo,
            this.colTenThuoc,
            this.colSoLuong,
            this.colDonGia,
            this.colDonViTinh,
            this.colTenLoai});
            this.lsvThuoc.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvThuoc.FullRowSelect = true;
            this.lsvThuoc.GridLines = true;
            this.lsvThuoc.HideSelection = false;
            this.lsvThuoc.Location = new System.Drawing.Point(24, 257);
            this.lsvThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvThuoc.Name = "lsvThuoc";
            this.lsvThuoc.Size = new System.Drawing.Size(939, 251);
            this.lsvThuoc.TabIndex = 15;
            this.lsvThuoc.UseCompatibleStateImageBehavior = false;
            this.lsvThuoc.View = System.Windows.Forms.View.Details;
            // 
            // colMaSo
            // 
            this.colMaSo.Text = "Mã thuốc";
            this.colMaSo.Width = 150;
            // 
            // colTenThuoc
            // 
            this.colTenThuoc.Text = "Tên thuốc";
            this.colTenThuoc.Width = 200;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            this.colSoLuong.Width = 150;
            // 
            // colDonGia
            // 
            this.colDonGia.Text = "Đơn giá";
            this.colDonGia.Width = 150;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.Text = "Đơn vị tính";
            this.colDonViTinh.Width = 200;
            // 
            // colTenLoai
            // 
            this.colTenLoai.Text = "Tên loại thuốc";
            this.colTenLoai.Width = 230;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbbTenL);
            this.groupControl1.Controls.Add(this.txtMaSo);
            this.groupControl1.Controls.Add(this.txtTenThuoc);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(168, 55);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(610, 184);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "Thông tin phiếu";
            // 
            // cbbTenL
            // 
            this.cbbTenL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenL.FormattingEnabled = true;
            this.cbbTenL.Location = new System.Drawing.Point(171, 138);
            this.cbbTenL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTenL.Name = "cbbTenL";
            this.cbbTenL.Size = new System.Drawing.Size(248, 27);
            this.cbbTenL.TabIndex = 6;
            // 
            // txtMaSo
            // 
            this.txtMaSo.Location = new System.Drawing.Point(171, 46);
            this.txtMaSo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSo.Properties.Appearance.Options.UseFont = true;
            this.txtMaSo.Size = new System.Drawing.Size(248, 26);
            this.txtMaSo.TabIndex = 1;
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(171, 95);
            this.txtTenThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenThuoc.Properties.Appearance.Options.UseFont = true;
            this.txtTenThuoc.Size = new System.Drawing.Size(248, 26);
            this.txtTenThuoc.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(63, 144);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(64, 17);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Tên Loại:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(61, 103);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên thuốc:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(91, 57);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã số:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(360, 11);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(212, 29);
            this.labelControl7.TabIndex = 67;
            this.labelControl7.Text = "TÌM KIẾM THUỐC";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(830, 512);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.ReadOnly = true;
            this.txtsoluong.Size = new System.Drawing.Size(64, 21);
            this.txtsoluong.TabIndex = 75;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(275, 535);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 44);
            this.button1.TabIndex = 74;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttThoat
            // 
            this.bttThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttThoat.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.Location = new System.Drawing.Point(830, 535);
            this.bttThoat.Margin = new System.Windows.Forms.Padding(2);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(75, 44);
            this.bttThoat.TabIndex = 73;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = true;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(767, 516);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 17);
            this.labelControl4.TabIndex = 77;
            this.labelControl4.Text = "Kết quả:";
            // 
            // frmtimkiemthuoc
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bttThoat;
            this.ClientSize = new System.Drawing.Size(1031, 587);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.lsvThuoc);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmtimkiemthuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm thuốc";
            this.Load += new System.EventHandler(this.frmtimkiemthuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenThuoc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvThuoc;
        private System.Windows.Forms.ColumnHeader colMaSo;
        private System.Windows.Forms.ColumnHeader colTenThuoc;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colDonGia;
        private System.Windows.Forms.ColumnHeader colDonViTinh;
        private System.Windows.Forms.ColumnHeader colTenLoai;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cbbTenL;
        private DevExpress.XtraEditors.TextEdit txtMaSo;
        private DevExpress.XtraEditors.TextEdit txtTenThuoc;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttThoat;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}