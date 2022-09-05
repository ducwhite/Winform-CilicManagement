
namespace QUANLYPHONGKHAMTU
{
    partial class frmchucvu
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
            this.bttLuu = new System.Windows.Forms.Button();
            this.bttSua = new System.Windows.Forms.Button();
            this.bttXoa = new System.Windows.Forms.Button();
            this.bttThem = new System.Windows.Forms.Button();
            this.lsvchucvu = new System.Windows.Forms.ListView();
            this.colMachucvu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTencv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txttencv = new DevExpress.XtraEditors.TextEdit();
            this.txtmacv = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttencv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmacv.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bttThoat
            // 
            this.bttThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttThoat.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.Location = new System.Drawing.Point(377, 380);
            this.bttThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(67, 51);
            this.bttThoat.TabIndex = 8;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = true;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // bttHuy
            // 
            this.bttHuy.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttHuy.Location = new System.Drawing.Point(297, 380);
            this.bttHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(67, 51);
            this.bttHuy.TabIndex = 7;
            this.bttHuy.Text = "Hủy";
            this.bttHuy.UseVisualStyleBackColor = true;
            this.bttHuy.Click += new System.EventHandler(this.bttHuy_Click);
            // 
            // bttLuu
            // 
            this.bttLuu.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLuu.Location = new System.Drawing.Point(225, 380);
            this.bttLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(67, 51);
            this.bttLuu.TabIndex = 6;
            this.bttLuu.Text = "Lưu";
            this.bttLuu.UseVisualStyleBackColor = true;
            this.bttLuu.Click += new System.EventHandler(this.bttLuu_Click);
            // 
            // bttSua
            // 
            this.bttSua.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSua.Location = new System.Drawing.Point(153, 380);
            this.bttSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(67, 51);
            this.bttSua.TabIndex = 5;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = true;
            this.bttSua.Click += new System.EventHandler(this.bttSua_Click);
            // 
            // bttXoa
            // 
            this.bttXoa.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXoa.Location = new System.Drawing.Point(81, 380);
            this.bttXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(67, 51);
            this.bttXoa.TabIndex = 4;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.UseVisualStyleBackColor = true;
            this.bttXoa.Click += new System.EventHandler(this.bttXoa_Click);
            // 
            // bttThem
            // 
            this.bttThem.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThem.Location = new System.Drawing.Point(9, 380);
            this.bttThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(67, 51);
            this.bttThem.TabIndex = 3;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = true;
            this.bttThem.Click += new System.EventHandler(this.bttThem_Click);
            // 
            // lsvchucvu
            // 
            this.lsvchucvu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMachucvu,
            this.colTencv});
            this.lsvchucvu.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvchucvu.FullRowSelect = true;
            this.lsvchucvu.GridLines = true;
            this.lsvchucvu.HideSelection = false;
            this.lsvchucvu.Location = new System.Drawing.Point(10, 162);
            this.lsvchucvu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvchucvu.MultiSelect = false;
            this.lsvchucvu.Name = "lsvchucvu";
            this.lsvchucvu.Size = new System.Drawing.Size(437, 214);
            this.lsvchucvu.TabIndex = 9;
            this.lsvchucvu.UseCompatibleStateImageBehavior = false;
            this.lsvchucvu.View = System.Windows.Forms.View.Details;
            this.lsvchucvu.SelectedIndexChanged += new System.EventHandler(this.lsvchucvu_SelectedIndexChanged);
            // 
            // colMachucvu
            // 
            this.colMachucvu.Text = "Mã chức vụ";
            this.colMachucvu.Width = 330;
            // 
            // colTencv
            // 
            this.colTencv.Text = "Tên chức vụ";
            this.colTencv.Width = 500;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txttencv);
            this.groupControl1.Controls.Add(this.txtmacv);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(10, 54);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(436, 102);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin chức vụ";
            // 
            // txttencv
            // 
            this.txttencv.Location = new System.Drawing.Point(118, 63);
            this.txttencv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttencv.Name = "txttencv";
            this.txttencv.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttencv.Properties.Appearance.Options.UseFont = true;
            this.txttencv.Size = new System.Drawing.Size(265, 26);
            this.txttencv.TabIndex = 2;
            // 
            // txtmacv
            // 
            this.txtmacv.Location = new System.Drawing.Point(118, 29);
            this.txtmacv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmacv.Name = "txtmacv";
            this.txtmacv.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmacv.Properties.Appearance.Options.UseFont = true;
            this.txtmacv.Size = new System.Drawing.Size(265, 26);
            this.txtmacv.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(20, 67);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên chức vụ:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(20, 32);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã chức vụ:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(111, 10);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(250, 29);
            this.labelControl3.TabIndex = 65;
            this.labelControl3.Text = "DANH MỤC CHỨC VỤ";
            // 
            // frmchucvu
            // 
            this.AcceptButton = this.bttThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bttThoat;
            this.ClientSize = new System.Drawing.Size(467, 443);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.bttSua);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.bttThem);
            this.Controls.Add(this.lsvchucvu);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmchucvu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục chức vụ";
            this.Load += new System.EventHandler(this.frmchucvu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttencv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmacv.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.Button bttHuy;
        private System.Windows.Forms.Button bttLuu;
        private System.Windows.Forms.Button bttSua;
        private System.Windows.Forms.Button bttXoa;
        private System.Windows.Forms.Button bttThem;
        private System.Windows.Forms.ListView lsvchucvu;
        private System.Windows.Forms.ColumnHeader colMachucvu;
        private System.Windows.Forms.ColumnHeader colTencv;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txttencv;
        private DevExpress.XtraEditors.TextEdit txtmacv;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}