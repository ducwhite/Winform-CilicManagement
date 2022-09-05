
namespace QUANLYPHONGKHAMTU
{
    partial class frmPhongKham
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
            this.lsvphongkham = new System.Windows.Forms.ListView();
            this.colMaPK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenPK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtTenPk = new DevExpress.XtraEditors.TextEdit();
            this.txtMapk = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.oDataInstantFeedbackSource1 = new DevExpress.Data.ODataLinq.ODataInstantFeedbackSource();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenPk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMapk.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bttThoat
            // 
            this.bttThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttThoat.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.Location = new System.Drawing.Point(418, 340);
            this.bttThoat.Margin = new System.Windows.Forms.Padding(2);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(69, 31);
            this.bttThoat.TabIndex = 8;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = true;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // bttHuy
            // 
            this.bttHuy.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttHuy.Location = new System.Drawing.Point(297, 340);
            this.bttHuy.Margin = new System.Windows.Forms.Padding(2);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(71, 31);
            this.bttHuy.TabIndex = 7;
            this.bttHuy.Text = "Hủy";
            this.bttHuy.UseVisualStyleBackColor = true;
            this.bttHuy.Click += new System.EventHandler(this.bttHuy_Click);
            // 
            // bttLuu
            // 
            this.bttLuu.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLuu.Location = new System.Drawing.Point(223, 340);
            this.bttLuu.Margin = new System.Windows.Forms.Padding(2);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(71, 31);
            this.bttLuu.TabIndex = 6;
            this.bttLuu.Text = "Lưu";
            this.bttLuu.UseVisualStyleBackColor = true;
            this.bttLuu.Click += new System.EventHandler(this.bttLuu_Click);
            // 
            // bttSua
            // 
            this.bttSua.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSua.Location = new System.Drawing.Point(150, 340);
            this.bttSua.Margin = new System.Windows.Forms.Padding(2);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(70, 31);
            this.bttSua.TabIndex = 5;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = true;
            this.bttSua.Click += new System.EventHandler(this.bttSua_Click);
            // 
            // bttXoa
            // 
            this.bttXoa.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXoa.Location = new System.Drawing.Point(78, 340);
            this.bttXoa.Margin = new System.Windows.Forms.Padding(2);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(69, 31);
            this.bttXoa.TabIndex = 4;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.UseVisualStyleBackColor = true;
            this.bttXoa.Click += new System.EventHandler(this.bttXoa_Click);
            // 
            // bttThem
            // 
            this.bttThem.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThem.Location = new System.Drawing.Point(13, 340);
            this.bttThem.Margin = new System.Windows.Forms.Padding(2);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(63, 31);
            this.bttThem.TabIndex = 3;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = true;
            this.bttThem.Click += new System.EventHandler(this.bttThem_Click);
            // 
            // lsvphongkham
            // 
            this.lsvphongkham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaPK,
            this.colTenPK});
            this.lsvphongkham.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvphongkham.FullRowSelect = true;
            this.lsvphongkham.GridLines = true;
            this.lsvphongkham.HideSelection = false;
            this.lsvphongkham.Location = new System.Drawing.Point(11, 145);
            this.lsvphongkham.Margin = new System.Windows.Forms.Padding(2);
            this.lsvphongkham.MultiSelect = false;
            this.lsvphongkham.Name = "lsvphongkham";
            this.lsvphongkham.Size = new System.Drawing.Size(477, 194);
            this.lsvphongkham.TabIndex = 9;
            this.lsvphongkham.UseCompatibleStateImageBehavior = false;
            this.lsvphongkham.View = System.Windows.Forms.View.Details;
            this.lsvphongkham.SelectedIndexChanged += new System.EventHandler(this.lsvphongkham_SelectedIndexChanged);
            // 
            // colMaPK
            // 
            this.colMaPK.Text = "Mã phòng khám";
            this.colMaPK.Width = 350;
            // 
            // colTenPK
            // 
            this.colTenPK.Text = "Tên phòng khám";
            this.colTenPK.Width = 400;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtTenPk);
            this.groupControl1.Controls.Add(this.txtMapk);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(11, 51);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(476, 90);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin phòng khám";
            // 
            // txtTenPk
            // 
            this.txtTenPk.EditValue = "";
            this.txtTenPk.Location = new System.Drawing.Point(133, 56);
            this.txtTenPk.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenPk.Name = "txtTenPk";
            this.txtTenPk.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPk.Properties.Appearance.Options.UseFont = true;
            this.txtTenPk.Size = new System.Drawing.Size(289, 26);
            this.txtTenPk.TabIndex = 2;
            // 
            // txtMapk
            // 
            this.txtMapk.EditValue = "";
            this.txtMapk.Location = new System.Drawing.Point(133, 25);
            this.txtMapk.Margin = new System.Windows.Forms.Padding(2);
            this.txtMapk.Name = "txtMapk";
            this.txtMapk.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMapk.Properties.Appearance.Options.UseFont = true;
            this.txtMapk.Size = new System.Drawing.Size(289, 26);
            this.txtMapk.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(17, 63);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(108, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên phòng khám:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(20, 32);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã phòng khám:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(78, 10);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(308, 29);
            this.labelControl5.TabIndex = 67;
            this.labelControl5.Text = "DANH MỤC PHÒNG KHÁM";
            // 
            // frmPhongKham
            // 
            this.AcceptButton = this.bttThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bttThoat;
            this.ClientSize = new System.Drawing.Size(497, 376);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.bttSua);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.bttThem);
            this.Controls.Add(this.lsvphongkham);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPhongKham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh mục phòng khám";
            this.Load += new System.EventHandler(this.frmPhongKham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenPk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMapk.Properties)).EndInit();
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
        private System.Windows.Forms.ListView lsvphongkham;
        private System.Windows.Forms.ColumnHeader colMaPK;
        private System.Windows.Forms.ColumnHeader colTenPK;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtTenPk;
        private DevExpress.XtraEditors.TextEdit txtMapk;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Data.ODataLinq.ODataInstantFeedbackSource oDataInstantFeedbackSource1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}