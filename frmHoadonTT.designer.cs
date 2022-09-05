
namespace QUANLYPHONGKHAMTU
{
    partial class frmHoadonTT
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
            this.bttHuy = new System.Windows.Forms.Button();
            this.bttSua = new System.Windows.Forms.Button();
            this.bttLuu = new System.Windows.Forms.Button();
            this.bttXoa = new System.Windows.Forms.Button();
            this.bttThem = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colMAHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coltenbn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colngaylap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMANV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coltongtien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bttThoat = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbbtenbn = new System.Windows.Forms.ComboBox();
            this.dtngaylap = new System.Windows.Forms.DateTimePicker();
            this.cbbtennv = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txttongtien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtmahd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.bttXem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttongtien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmahd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bttHuy
            // 
            this.bttHuy.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttHuy.Location = new System.Drawing.Point(319, 439);
            this.bttHuy.Margin = new System.Windows.Forms.Padding(2);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(71, 47);
            this.bttHuy.TabIndex = 10;
            this.bttHuy.Text = "Hủy";
            this.bttHuy.UseVisualStyleBackColor = true;
            this.bttHuy.Click += new System.EventHandler(this.bttHuy_Click);
            // 
            // bttSua
            // 
            this.bttSua.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSua.Location = new System.Drawing.Point(170, 439);
            this.bttSua.Margin = new System.Windows.Forms.Padding(2);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(71, 47);
            this.bttSua.TabIndex = 8;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = true;
            this.bttSua.Click += new System.EventHandler(this.bttSua_Click);
            // 
            // bttLuu
            // 
            this.bttLuu.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLuu.Location = new System.Drawing.Point(244, 439);
            this.bttLuu.Margin = new System.Windows.Forms.Padding(2);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(71, 47);
            this.bttLuu.TabIndex = 9;
            this.bttLuu.Text = "Lưu";
            this.bttLuu.UseVisualStyleBackColor = true;
            this.bttLuu.Click += new System.EventHandler(this.bttLuu_Click);
            // 
            // bttXoa
            // 
            this.bttXoa.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXoa.Location = new System.Drawing.Point(95, 439);
            this.bttXoa.Margin = new System.Windows.Forms.Padding(2);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(71, 47);
            this.bttXoa.TabIndex = 7;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.UseVisualStyleBackColor = true;
            this.bttXoa.Click += new System.EventHandler(this.bttXoa_Click);
            // 
            // bttThem
            // 
            this.bttThem.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThem.Location = new System.Drawing.Point(20, 439);
            this.bttThem.Margin = new System.Windows.Forms.Padding(2);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(71, 47);
            this.bttThem.TabIndex = 6;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = true;
            this.bttThem.Click += new System.EventHandler(this.bttThem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMAHD,
            this.coltenbn,
            this.colngaylap,
            this.colMANV,
            this.coltongtien});
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(41, 235);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(456, 185);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colMAHD
            // 
            this.colMAHD.Text = "Mã Hóa đơn";
            this.colMAHD.Width = 170;
            // 
            // coltenbn
            // 
            this.coltenbn.Text = "Tên bệnh nhân";
            this.coltenbn.Width = 200;
            // 
            // colngaylap
            // 
            this.colngaylap.Text = "Ngày lập";
            this.colngaylap.Width = 180;
            // 
            // colMANV
            // 
            this.colMANV.Text = "Tên NV";
            this.colMANV.Width = 200;
            // 
            // coltongtien
            // 
            this.coltongtien.Text = "Tổng tiền";
            this.coltongtien.Width = 150;
            // 
            // bttThoat
            // 
            this.bttThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttThoat.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.Location = new System.Drawing.Point(467, 438);
            this.bttThoat.Margin = new System.Windows.Forms.Padding(2);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(71, 48);
            this.bttThoat.TabIndex = 11;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = true;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbbtenbn);
            this.groupControl1.Controls.Add(this.dtngaylap);
            this.groupControl1.Controls.Add(this.cbbtennv);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txttongtien);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtmahd);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Location = new System.Drawing.Point(41, 56);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(453, 175);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin phiếu";
            // 
            // cbbtenbn
            // 
            this.cbbtenbn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbtenbn.FormattingEnabled = true;
            this.cbbtenbn.Location = new System.Drawing.Point(121, 56);
            this.cbbtenbn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbtenbn.Name = "cbbtenbn";
            this.cbbtenbn.Size = new System.Drawing.Size(189, 25);
            this.cbbtenbn.TabIndex = 2;
            // 
            // dtngaylap
            // 
            this.dtngaylap.CustomFormat = "dd/MM/yyyy";
            this.dtngaylap.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaylap.Location = new System.Drawing.Point(121, 83);
            this.dtngaylap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtngaylap.Name = "dtngaylap";
            this.dtngaylap.Size = new System.Drawing.Size(261, 24);
            this.dtngaylap.TabIndex = 3;
            // 
            // cbbtennv
            // 
            this.cbbtennv.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbtennv.FormattingEnabled = true;
            this.cbbtennv.Location = new System.Drawing.Point(121, 109);
            this.cbbtennv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbtennv.Name = "cbbtennv";
            this.cbbtennv.Size = new System.Drawing.Size(189, 25);
            this.cbbtennv.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(30, 32);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã hóa đơn:";
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(121, 135);
            this.txttongtien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttongtien.Properties.Appearance.Options.UseFont = true;
            this.txttongtien.Size = new System.Drawing.Size(261, 24);
            this.txttongtien.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(45, 140);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tổng tiền:";
            // 
            // txtmahd
            // 
            this.txtmahd.Location = new System.Drawing.Point(121, 26);
            this.txtmahd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmahd.Properties.Appearance.Options.UseFont = true;
            this.txtmahd.Size = new System.Drawing.Size(261, 24);
            this.txtmahd.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(57, 110);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 17);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tên NV:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(50, 86);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(61, 17);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Ngày lập:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 58);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(102, 17);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Tên bệnh nhân:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(136, 11);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(285, 29);
            this.labelControl6.TabIndex = 66;
            this.labelControl6.Text = "HÓA ĐƠN THANH TOÁN";
            // 
            // bttXem
            // 
            this.bttXem.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXem.Location = new System.Drawing.Point(392, 438);
            this.bttXem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttXem.Name = "bttXem";
            this.bttXem.Size = new System.Drawing.Size(71, 48);
            this.bttXem.TabIndex = 68;
            this.bttXem.Text = "Xem CT";
            this.bttXem.UseVisualStyleBackColor = true;
            this.bttXem.Click += new System.EventHandler(this.bttXem_Click);
            // 
            // frmHoadonTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 522);
            this.Controls.Add(this.bttXem);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.bttSua);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.bttThem);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bttThoat);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHoadonTT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn thanh toán";
            this.Load += new System.EventHandler(this.frmHoadonTT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttongtien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmahd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttHuy;
        private System.Windows.Forms.Button bttSua;
        private System.Windows.Forms.Button bttLuu;
        private System.Windows.Forms.Button bttXoa;
        private System.Windows.Forms.Button bttThem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.ColumnHeader colMAHD;
        private System.Windows.Forms.ColumnHeader coltenbn;
        private System.Windows.Forms.ColumnHeader colngaylap;
        private System.Windows.Forms.ColumnHeader colMANV;
        private System.Windows.Forms.ColumnHeader coltongtien;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cbbtenbn;
        private System.Windows.Forms.DateTimePicker dtngaylap;
        private System.Windows.Forms.ComboBox cbbtennv;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txttongtien;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtmahd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.Button bttXem;
    }
}