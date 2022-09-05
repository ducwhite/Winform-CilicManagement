
namespace QUANLYPHONGKHAMTU
{
    partial class frmDantoc
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
            this.lsvdantoc = new System.Windows.Forms.ListView();
            this.colMadantoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTendantoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txttendt = new DevExpress.XtraEditors.TextEdit();
            this.txtmadt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttendt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmadt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bttThoat
            // 
            this.bttThoat.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.Location = new System.Drawing.Point(379, 375);
            this.bttThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(67, 50);
            this.bttThoat.TabIndex = 15;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = true;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // bttHuy
            // 
            this.bttHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttHuy.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttHuy.Location = new System.Drawing.Point(307, 375);
            this.bttHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(67, 50);
            this.bttHuy.TabIndex = 14;
            this.bttHuy.Text = "Hủy";
            this.bttHuy.UseVisualStyleBackColor = true;
            this.bttHuy.Click += new System.EventHandler(this.bttHuy_Click);
            // 
            // bttLuu
            // 
            this.bttLuu.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLuu.Location = new System.Drawing.Point(235, 375);
            this.bttLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(67, 50);
            this.bttLuu.TabIndex = 13;
            this.bttLuu.Text = "Lưu";
            this.bttLuu.UseVisualStyleBackColor = true;
            this.bttLuu.Click += new System.EventHandler(this.bttLuu_Click);
            // 
            // bttSua
            // 
            this.bttSua.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSua.Location = new System.Drawing.Point(163, 375);
            this.bttSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(67, 50);
            this.bttSua.TabIndex = 12;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = true;
            this.bttSua.Click += new System.EventHandler(this.bttSua_Click);
            // 
            // bttXoa
            // 
            this.bttXoa.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXoa.Location = new System.Drawing.Point(91, 375);
            this.bttXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(67, 50);
            this.bttXoa.TabIndex = 11;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.UseVisualStyleBackColor = true;
            this.bttXoa.Click += new System.EventHandler(this.bttXoa_Click);
            // 
            // bttThem
            // 
            this.bttThem.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThem.Location = new System.Drawing.Point(19, 375);
            this.bttThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(67, 50);
            this.bttThem.TabIndex = 10;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = true;
            this.bttThem.Click += new System.EventHandler(this.bttThem_Click);
            // 
            // lsvdantoc
            // 
            this.lsvdantoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMadantoc,
            this.colTendantoc});
            this.lsvdantoc.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvdantoc.FullRowSelect = true;
            this.lsvdantoc.GridLines = true;
            this.lsvdantoc.HideSelection = false;
            this.lsvdantoc.Location = new System.Drawing.Point(19, 157);
            this.lsvdantoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvdantoc.MultiSelect = false;
            this.lsvdantoc.Name = "lsvdantoc";
            this.lsvdantoc.Size = new System.Drawing.Size(428, 214);
            this.lsvdantoc.TabIndex = 9;
            this.lsvdantoc.UseCompatibleStateImageBehavior = false;
            this.lsvdantoc.View = System.Windows.Forms.View.Details;
            this.lsvdantoc.SelectedIndexChanged += new System.EventHandler(this.lsvdantoc_SelectedIndexChanged);
            // 
            // colMadantoc
            // 
            this.colMadantoc.Text = "Mã dân tộc";
            this.colMadantoc.Width = 250;
            // 
            // colTendantoc
            // 
            this.colTendantoc.Text = "Tên dân tộc";
            this.colTendantoc.Width = 400;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txttendt);
            this.groupControl1.Controls.Add(this.txtmadt);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(19, 41);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(426, 110);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin phiếu ";
            // 
            // txttendt
            // 
            this.txttendt.Location = new System.Drawing.Point(118, 63);
            this.txttendt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttendt.Name = "txttendt";
            this.txttendt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttendt.Properties.Appearance.Options.UseFont = true;
            this.txttendt.Size = new System.Drawing.Size(238, 26);
            this.txttendt.TabIndex = 1;
            // 
            // txtmadt
            // 
            this.txtmadt.Location = new System.Drawing.Point(118, 29);
            this.txtmadt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmadt.Name = "txtmadt";
            this.txtmadt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmadt.Properties.Appearance.Options.UseFont = true;
            this.txtmadt.Size = new System.Drawing.Size(238, 26);
            this.txtmadt.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(20, 67);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên dân tộc:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 32);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã dân tộc:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(106, 7);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(249, 29);
            this.labelControl3.TabIndex = 66;
            this.labelControl3.Text = "DANH MỤC DÂN TỘC";
            // 
            // frmDantoc
            // 
            this.AcceptButton = this.bttThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bttHuy;
            this.ClientSize = new System.Drawing.Size(463, 448);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.bttSua);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.bttThem);
            this.Controls.Add(this.lsvdantoc);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDantoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục dân tộc";
            this.Load += new System.EventHandler(this.frmDantoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttendt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmadt.Properties)).EndInit();
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
        private System.Windows.Forms.ListView lsvdantoc;
        private System.Windows.Forms.ColumnHeader colMadantoc;
        private System.Windows.Forms.ColumnHeader colTendantoc;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txttendt;
        private DevExpress.XtraEditors.TextEdit txtmadt;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}