
namespace Quanlyphongkham
{
    partial class frmtiemkiembacsy
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.listView1 = new System.Windows.Forms.ListView();
            this.MABS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenBS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaysinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gioitinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dantoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DIEUTRI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbbpk = new System.Windows.Forms.ComboBox();
            this.cbbkdt = new System.Windows.Forms.ComboBox();
            this.lable = new DevExpress.XtraEditors.LabelControl();
            this.txttenbs = new DevExpress.XtraEditors.TextEdit();
            this.txtdienthoai = new DevExpress.XtraEditors.TextEdit();
            this.txtmabs = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bttThoat = new System.Windows.Forms.Button();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttenbs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdienthoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmabs.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(261, 2);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(213, 29);
            this.labelControl3.TabIndex = 67;
            this.labelControl3.Text = "TÌM KIẾM BÁC SỸ";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MABS,
            this.TenBS,
            this.ngaysinh,
            this.gioitinh,
            this.SDT,
            this.dantoc,
            this.DIEUTRI,
            this.PK});
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(51, 239);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(679, 216);
            this.listView1.TabIndex = 66;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // MABS
            // 
            this.MABS.Text = "MABS";
            this.MABS.Width = 150;
            // 
            // TenBS
            // 
            this.TenBS.Text = "Tên BS";
            this.TenBS.Width = 250;
            // 
            // ngaysinh
            // 
            this.ngaysinh.Text = "Ngày sinh";
            this.ngaysinh.Width = 200;
            // 
            // gioitinh
            // 
            this.gioitinh.Text = "Giới tính";
            this.gioitinh.Width = 150;
            // 
            // SDT
            // 
            this.SDT.Text = "SDT";
            this.SDT.Width = 100;
            // 
            // dantoc
            // 
            this.dantoc.Text = "Dân tộc";
            this.dantoc.Width = 120;
            // 
            // DIEUTRI
            // 
            this.DIEUTRI.Text = "Khoa điều trị";
            this.DIEUTRI.Width = 200;
            // 
            // PK
            // 
            this.PK.Text = "Phòng Khám";
            this.PK.Width = 200;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.cbbpk);
            this.groupControl1.Controls.Add(this.cbbkdt);
            this.groupControl1.Controls.Add(this.lable);
            this.groupControl1.Controls.Add(this.txttenbs);
            this.groupControl1.Controls.Add(this.txtdienthoai);
            this.groupControl1.Controls.Add(this.txtmabs);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(51, 36);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(677, 188);
            this.groupControl1.TabIndex = 65;
            this.groupControl1.Text = "Thông tin bác sỹ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(73, 152);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 17);
            this.labelControl2.TabIndex = 65;
            this.labelControl2.Text = "Phòng khám:";
            // 
            // cbbpk
            // 
            this.cbbpk.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbpk.FormattingEnabled = true;
            this.cbbpk.Location = new System.Drawing.Point(165, 149);
            this.cbbpk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbpk.Name = "cbbpk";
            this.cbbpk.Size = new System.Drawing.Size(172, 25);
            this.cbbpk.TabIndex = 9;
            // 
            // cbbkdt
            // 
            this.cbbkdt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbkdt.FormattingEnabled = true;
            this.cbbkdt.Location = new System.Drawing.Point(165, 122);
            this.cbbkdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbkdt.Name = "cbbkdt";
            this.cbbkdt.Size = new System.Drawing.Size(172, 25);
            this.cbbkdt.TabIndex = 8;
            // 
            // lable
            // 
            this.lable.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.Appearance.Options.UseFont = true;
            this.lable.Location = new System.Drawing.Point(65, 125);
            this.lable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(91, 17);
            this.lable.TabIndex = 62;
            this.lable.Text = "Khoa điều trị:";
            // 
            // txttenbs
            // 
            this.txttenbs.Location = new System.Drawing.Point(165, 55);
            this.txttenbs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttenbs.Name = "txttenbs";
            this.txttenbs.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenbs.Properties.Appearance.Options.UseFont = true;
            this.txttenbs.Size = new System.Drawing.Size(376, 24);
            this.txttenbs.TabIndex = 2;
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(165, 92);
            this.txtdienthoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdienthoai.Properties.Appearance.Options.UseFont = true;
            this.txtdienthoai.Size = new System.Drawing.Size(170, 24);
            this.txtdienthoai.TabIndex = 6;
            // 
            // txtmabs
            // 
            this.txtmabs.Location = new System.Drawing.Point(165, 27);
            this.txtmabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmabs.Name = "txtmabs";
            this.txtmabs.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmabs.Properties.Appearance.Options.UseFont = true;
            this.txtmabs.Size = new System.Drawing.Size(376, 24);
            this.txtmabs.TabIndex = 1;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(63, 60);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(92, 17);
            this.labelControl11.TabIndex = 10;
            this.labelControl11.Text = "Họ và tên BS:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(87, 96);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 17);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Điện thoại:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(111, 31);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã BS:";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(655, 471);
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
            this.button1.Location = new System.Drawing.Point(130, 494);
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
            this.bttThoat.Location = new System.Drawing.Point(655, 494);
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
            this.labelControl4.Location = new System.Drawing.Point(592, 475);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 17);
            this.labelControl4.TabIndex = 76;
            this.labelControl4.Text = "Kết quả:";
            // 
            // frmtiemkiembacsy
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bttThoat;
            this.ClientSize = new System.Drawing.Size(793, 561);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmtiemkiembacsy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm bác sỹ";
            this.Load += new System.EventHandler(this.frmtiemkiembacsy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttenbs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdienthoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmabs.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader MABS;
        private System.Windows.Forms.ColumnHeader TenBS;
        private System.Windows.Forms.ColumnHeader ngaysinh;
        private System.Windows.Forms.ColumnHeader gioitinh;
        private System.Windows.Forms.ColumnHeader SDT;
        private System.Windows.Forms.ColumnHeader dantoc;
        private System.Windows.Forms.ColumnHeader DIEUTRI;
        private System.Windows.Forms.ColumnHeader PK;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cbbpk;
        private System.Windows.Forms.ComboBox cbbkdt;
        private DevExpress.XtraEditors.LabelControl lable;
        private DevExpress.XtraEditors.TextEdit txttenbs;
        private DevExpress.XtraEditors.TextEdit txtdienthoai;
        private DevExpress.XtraEditors.TextEdit txtmabs;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttThoat;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}