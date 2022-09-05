
namespace QUANLYPHONGKHAMTU
{
    partial class frmctsddv
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
            this.lsvctsddv = new System.Windows.Forms.ListView();
            this.colMaPCLS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTendantoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbbmadv = new System.Windows.Forms.ComboBox();
            this.cbbmapcls = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttThoat
            // 
            this.bttThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttThoat.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.Location = new System.Drawing.Point(377, 392);
            this.bttThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(67, 47);
            this.bttThoat.TabIndex = 8;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = true;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // bttHuy
            // 
            this.bttHuy.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttHuy.Location = new System.Drawing.Point(305, 392);
            this.bttHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(67, 47);
            this.bttHuy.TabIndex = 7;
            this.bttHuy.Text = "Hủy";
            this.bttHuy.UseVisualStyleBackColor = true;
            this.bttHuy.Click += new System.EventHandler(this.bttHuy_Click);
            // 
            // bttLuu
            // 
            this.bttLuu.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLuu.Location = new System.Drawing.Point(233, 392);
            this.bttLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(67, 47);
            this.bttLuu.TabIndex = 6;
            this.bttLuu.Text = "Lưu";
            this.bttLuu.UseVisualStyleBackColor = true;
            this.bttLuu.Click += new System.EventHandler(this.bttLuu_Click);
            // 
            // bttSua
            // 
            this.bttSua.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSua.Location = new System.Drawing.Point(161, 392);
            this.bttSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(67, 47);
            this.bttSua.TabIndex = 5;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = true;
            this.bttSua.Click += new System.EventHandler(this.bttSua_Click);
            // 
            // bttXoa
            // 
            this.bttXoa.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXoa.Location = new System.Drawing.Point(89, 392);
            this.bttXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(67, 47);
            this.bttXoa.TabIndex = 4;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.UseVisualStyleBackColor = true;
            this.bttXoa.Click += new System.EventHandler(this.bttXoa_Click);
            // 
            // bttThem
            // 
            this.bttThem.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThem.Location = new System.Drawing.Point(17, 392);
            this.bttThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(67, 47);
            this.bttThem.TabIndex = 3;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = true;
            this.bttThem.Click += new System.EventHandler(this.bttThem_Click);
            // 
            // lsvctsddv
            // 
            this.lsvctsddv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaPCLS,
            this.colTendantoc});
            this.lsvctsddv.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvctsddv.FullRowSelect = true;
            this.lsvctsddv.GridLines = true;
            this.lsvctsddv.HideSelection = false;
            this.lsvctsddv.Location = new System.Drawing.Point(17, 135);
            this.lsvctsddv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvctsddv.MultiSelect = false;
            this.lsvctsddv.Name = "lsvctsddv";
            this.lsvctsddv.Size = new System.Drawing.Size(428, 254);
            this.lsvctsddv.TabIndex = 8;
            this.lsvctsddv.UseCompatibleStateImageBehavior = false;
            this.lsvctsddv.View = System.Windows.Forms.View.Details;
            this.lsvctsddv.SelectedIndexChanged += new System.EventHandler(this.lsvdantoc_SelectedIndexChanged);
            // 
            // colMaPCLS
            // 
            this.colMaPCLS.Text = "Mã PCLS";
            this.colMaPCLS.Width = 350;
            // 
            // colTendantoc
            // 
            this.colTendantoc.Text = "TÊN DỊCH VỤ";
            this.colTendantoc.Width = 400;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbbmadv);
            this.groupControl1.Controls.Add(this.cbbmapcls);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(17, 47);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(427, 82);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin phiếu";
            // 
            // cbbmadv
            // 
            this.cbbmadv.FormattingEnabled = true;
            this.cbbmadv.Location = new System.Drawing.Point(171, 55);
            this.cbbmadv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbmadv.Name = "cbbmadv";
            this.cbbmadv.Size = new System.Drawing.Size(212, 21);
            this.cbbmadv.TabIndex = 2;
            // 
            // cbbmapcls
            // 
            this.cbbmapcls.FormattingEnabled = true;
            this.cbbmapcls.Location = new System.Drawing.Point(171, 32);
            this.cbbmapcls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbmapcls.Name = "cbbmapcls";
            this.cbbmapcls.Size = new System.Drawing.Size(212, 21);
            this.cbbmapcls.TabIndex = 1;
            this.cbbmapcls.SelectedIndexChanged += new System.EventHandler(this.cbbmapcls_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(84, 54);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên dịch vụ:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(0, 32);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(154, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã phiếu cận lâm sàng:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(124, 2);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(184, 29);
            this.labelControl3.TabIndex = 66;
            this.labelControl3.Text = "CHI TIẾT SDDV";
            // 
            // frmctsddv
            // 
            this.AcceptButton = this.bttThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bttThoat;
            this.ClientSize = new System.Drawing.Size(463, 461);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.bttSua);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.bttThem);
            this.Controls.Add(this.lsvctsddv);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmctsddv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết SDDV";
            this.Load += new System.EventHandler(this.frmctsddv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
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
        private System.Windows.Forms.ListView lsvctsddv;
        private System.Windows.Forms.ColumnHeader colMaPCLS;
        private System.Windows.Forms.ColumnHeader colTendantoc;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cbbmadv;
        private System.Windows.Forms.ComboBox cbbmapcls;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}