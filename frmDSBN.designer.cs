
namespace QUANLYPHONGKHAMTU
{
    partial class frmDSBN
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
            this.nghenghiep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaysinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dantoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gioitinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.diachi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MABN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.SDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.radiobtnu = new System.Windows.Forms.RadioButton();
            this.radiobtnam = new System.Windows.Forms.RadioButton();
            this.lable = new DevExpress.XtraEditors.LabelControl();
            this.txtnghenghiep = new DevExpress.XtraEditors.TextEdit();
            this.cbbdantoc = new System.Windows.Forms.ComboBox();
            this.txtdiachi = new DevExpress.XtraEditors.TextEdit();
            this.txthoten = new DevExpress.XtraEditors.TextEdit();
            this.txtdienthoai = new DevExpress.XtraEditors.TextEdit();
            this.txtmabn = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bttThoat = new System.Windows.Forms.Button();
            this.bttHuy = new System.Windows.Forms.Button();
            this.bttSua = new System.Windows.Forms.Button();
            this.bttLuu = new System.Windows.Forms.Button();
            this.bttXoa = new System.Windows.Forms.Button();
            this.bttThem = new System.Windows.Forms.Button();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnghenghiep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthoten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdienthoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmabn.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nghenghiep
            // 
            this.nghenghiep.Text = "Nghề nghiệp";
            this.nghenghiep.Width = 260;
            // 
            // ngaysinh
            // 
            this.ngaysinh.Text = "Ngày sinh";
            this.ngaysinh.Width = 150;
            // 
            // dantoc
            // 
            this.dantoc.Text = "Dân tộc";
            this.dantoc.Width = 120;
            // 
            // gioitinh
            // 
            this.gioitinh.Text = "Giới tính";
            this.gioitinh.Width = 130;
            // 
            // diachi
            // 
            this.diachi.Text = "Địa chỉ";
            this.diachi.Width = 200;
            // 
            // TenBN
            // 
            this.TenBN.Text = "Tên BN";
            this.TenBN.Width = 200;
            // 
            // MABN
            // 
            this.MABN.Text = "MABN";
            this.MABN.Width = 130;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MABN,
            this.TenBN,
            this.ngaysinh,
            this.gioitinh,
            this.diachi,
            this.SDT,
            this.dantoc,
            this.nghenghiep});
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 289);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(675, 175);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // SDT
            // 
            this.SDT.Text = "SDT";
            this.SDT.Width = 150;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dtngaysinh);
            this.groupControl1.Controls.Add(this.radiobtnu);
            this.groupControl1.Controls.Add(this.radiobtnam);
            this.groupControl1.Controls.Add(this.lable);
            this.groupControl1.Controls.Add(this.txtnghenghiep);
            this.groupControl1.Controls.Add(this.cbbdantoc);
            this.groupControl1.Controls.Add(this.txtdiachi);
            this.groupControl1.Controls.Add(this.txthoten);
            this.groupControl1.Controls.Add(this.txtdienthoai);
            this.groupControl1.Controls.Add(this.txtmabn);
            this.groupControl1.Controls.Add(this.labelControl15);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(7, 42);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(673, 237);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin bệnh nhân";
            // 
            // dtngaysinh
            // 
            this.dtngaysinh.CustomFormat = "dd/MM/yyyy";
            this.dtngaysinh.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaysinh.Location = new System.Drawing.Point(117, 89);
            this.dtngaysinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtngaysinh.Name = "dtngaysinh";
            this.dtngaysinh.Size = new System.Drawing.Size(219, 24);
            this.dtngaysinh.TabIndex = 3;
            // 
            // radiobtnu
            // 
            this.radiobtnu.AutoSize = true;
            this.radiobtnu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnu.Location = new System.Drawing.Point(458, 88);
            this.radiobtnu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radiobtnu.Name = "radiobtnu";
            this.radiobtnu.Size = new System.Drawing.Size(44, 21);
            this.radiobtnu.TabIndex = 5;
            this.radiobtnu.TabStop = true;
            this.radiobtnu.Text = "Nữ";
            this.radiobtnu.UseVisualStyleBackColor = true;
            // 
            // radiobtnam
            // 
            this.radiobtnam.AutoSize = true;
            this.radiobtnam.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnam.Location = new System.Drawing.Point(407, 88);
            this.radiobtnam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radiobtnam.Name = "radiobtnam";
            this.radiobtnam.Size = new System.Drawing.Size(54, 21);
            this.radiobtnam.TabIndex = 4;
            this.radiobtnam.TabStop = true;
            this.radiobtnam.Text = "Nam";
            this.radiobtnam.UseVisualStyleBackColor = true;
            // 
            // lable
            // 
            this.lable.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.Appearance.Options.UseFont = true;
            this.lable.Location = new System.Drawing.Point(27, 205);
            this.lable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(88, 17);
            this.lable.TabIndex = 62;
            this.lable.Text = "Nghề nghiệp:";
            // 
            // txtnghenghiep
            // 
            this.txtnghenghiep.Location = new System.Drawing.Point(117, 202);
            this.txtnghenghiep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnghenghiep.Name = "txtnghenghiep";
            this.txtnghenghiep.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnghenghiep.Properties.Appearance.Options.UseFont = true;
            this.txtnghenghiep.Size = new System.Drawing.Size(460, 24);
            this.txtnghenghiep.TabIndex = 9;
            // 
            // cbbdantoc
            // 
            this.cbbdantoc.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbdantoc.FormattingEnabled = true;
            this.cbbdantoc.Location = new System.Drawing.Point(117, 175);
            this.cbbdantoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbdantoc.Name = "cbbdantoc";
            this.cbbdantoc.Size = new System.Drawing.Size(104, 25);
            this.cbbdantoc.TabIndex = 8;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(117, 115);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Properties.Appearance.Options.UseFont = true;
            this.txtdiachi.Size = new System.Drawing.Size(460, 24);
            this.txtdiachi.TabIndex = 6;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(117, 56);
            this.txthoten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txthoten.Name = "txthoten";
            this.txthoten.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoten.Properties.Appearance.Options.UseFont = true;
            this.txthoten.Size = new System.Drawing.Size(460, 24);
            this.txthoten.TabIndex = 2;
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(117, 145);
            this.txtdienthoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdienthoai.Properties.Appearance.Options.UseFont = true;
            this.txtdienthoai.Size = new System.Drawing.Size(460, 24);
            this.txtdienthoai.TabIndex = 7;
            // 
            // txtmabn
            // 
            this.txtmabn.Location = new System.Drawing.Point(117, 28);
            this.txtmabn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmabn.Name = "txtmabn";
            this.txtmabn.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmabn.Properties.Appearance.Options.UseFont = true;
            this.txtmabn.Size = new System.Drawing.Size(103, 24);
            this.txtmabn.TabIndex = 1;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(54, 177);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(55, 17);
            this.labelControl15.TabIndex = 14;
            this.labelControl15.Text = "Dân tộc:";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(339, 89);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(61, 17);
            this.labelControl14.TabIndex = 13;
            this.labelControl14.Text = "Giới tính:";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(40, 89);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(65, 17);
            this.labelControl12.TabIndex = 11;
            this.labelControl12.Text = "Ngày sinh:";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(17, 59);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(95, 17);
            this.labelControl11.TabIndex = 10;
            this.labelControl11.Text = "Họ và tên BN:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(40, 145);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 17);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Điện thoại:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(58, 119);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 17);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Địa chỉ:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(58, 32);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã BN:";
            // 
            // bttThoat
            // 
            this.bttThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttThoat.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.Location = new System.Drawing.Point(604, 473);
            this.bttThoat.Margin = new System.Windows.Forms.Padding(2);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(75, 44);
            this.bttThoat.TabIndex = 15;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = true;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // bttHuy
            // 
            this.bttHuy.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttHuy.Location = new System.Drawing.Point(352, 473);
            this.bttHuy.Margin = new System.Windows.Forms.Padding(2);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(75, 44);
            this.bttHuy.TabIndex = 14;
            this.bttHuy.Text = "Hủy";
            this.bttHuy.UseVisualStyleBackColor = true;
            this.bttHuy.Click += new System.EventHandler(this.bttHuy_Click);
            // 
            // bttSua
            // 
            this.bttSua.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSua.Location = new System.Drawing.Point(179, 473);
            this.bttSua.Margin = new System.Windows.Forms.Padding(2);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(75, 44);
            this.bttSua.TabIndex = 12;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = true;
            this.bttSua.Click += new System.EventHandler(this.bttSua_Click);
            // 
            // bttLuu
            // 
            this.bttLuu.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLuu.Location = new System.Drawing.Point(265, 473);
            this.bttLuu.Margin = new System.Windows.Forms.Padding(2);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(75, 44);
            this.bttLuu.TabIndex = 13;
            this.bttLuu.Text = "Lưu";
            this.bttLuu.UseVisualStyleBackColor = true;
            this.bttLuu.Click += new System.EventHandler(this.bttLuu_Click);
            // 
            // bttXoa
            // 
            this.bttXoa.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXoa.Location = new System.Drawing.Point(93, 473);
            this.bttXoa.Margin = new System.Windows.Forms.Padding(2);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(75, 44);
            this.bttXoa.TabIndex = 11;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.UseVisualStyleBackColor = true;
            this.bttXoa.Click += new System.EventHandler(this.bttXoa_Click);
            // 
            // bttThem
            // 
            this.bttThem.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThem.Location = new System.Drawing.Point(7, 473);
            this.bttThem.Margin = new System.Windows.Forms.Padding(2);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(75, 44);
            this.bttThem.TabIndex = 10;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = true;
            this.bttThem.Click += new System.EventHandler(this.bttThem_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(197, -1);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(262, 29);
            this.labelControl3.TabIndex = 66;
            this.labelControl3.Text = "QUẢN LÝ BỆNH NHÂN";
            // 
            // frmDSBN
            // 
            this.AcceptButton = this.bttThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bttThoat;
            this.ClientSize = new System.Drawing.Size(699, 524);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.bttSua);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.bttThem);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDSBN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách bệnh nhân";
            this.Load += new System.EventHandler(this.frmDSBN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnghenghiep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthoten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdienthoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmabn.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader nghenghiep;
        private System.Windows.Forms.ColumnHeader ngaysinh;
        private System.Windows.Forms.ColumnHeader dantoc;
        private System.Windows.Forms.ColumnHeader gioitinh;
        private System.Windows.Forms.ColumnHeader diachi;
        private System.Windows.Forms.ColumnHeader TenBN;
        private System.Windows.Forms.ColumnHeader MABN;
        private System.Windows.Forms.ListView listView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txthoten;
        private DevExpress.XtraEditors.TextEdit txtdienthoai;
        private DevExpress.XtraEditors.TextEdit txtmabn;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtdiachi;
        private System.Windows.Forms.ColumnHeader SDT;
        private System.Windows.Forms.ComboBox cbbdantoc;
        private DevExpress.XtraEditors.LabelControl lable;
        private DevExpress.XtraEditors.TextEdit txtnghenghiep;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.Button bttHuy;
        private System.Windows.Forms.Button bttSua;
        private System.Windows.Forms.Button bttLuu;
        private System.Windows.Forms.Button bttXoa;
        private System.Windows.Forms.Button bttThem;
        private System.Windows.Forms.RadioButton radiobtnu;
        private System.Windows.Forms.RadioButton radiobtnam;
        private System.Windows.Forms.DateTimePicker dtngaysinh;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}