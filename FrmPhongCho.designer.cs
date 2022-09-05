
namespace Quanlyphongkham
{
    partial class FrmPhongCho
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbbTenPK = new System.Windows.Forms.ComboBox();
            this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.radbttTatCa = new System.Windows.Forms.RadioButton();
            this.radbttDaKham = new System.Windows.Forms.RadioButton();
            this.radbttChuaKham = new System.Windows.Forms.RadioButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lsvCT = new System.Windows.Forms.ListView();
            this.colMaPhieuKB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTenBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLoaiKham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTinhTrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bttThoat = new System.Windows.Forms.Button();
            this.bttXem = new System.Windows.Forms.Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbT = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbbTenPK);
            this.groupControl1.Controls.Add(this.dtNgayLap);
            this.groupControl1.Controls.Add(this.radbttTatCa);
            this.groupControl1.Controls.Add(this.radbttDaKham);
            this.groupControl1.Controls.Add(this.radbttChuaKham);
            this.groupControl1.Location = new System.Drawing.Point(12, 57);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(876, 55);
            this.groupControl1.TabIndex = 0;
            // 
            // cbbTenPK
            // 
            this.cbbTenPK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenPK.FormattingEnabled = true;
            this.cbbTenPK.Location = new System.Drawing.Point(610, 22);
            this.cbbTenPK.Name = "cbbTenPK";
            this.cbbTenPK.Size = new System.Drawing.Size(248, 27);
            this.cbbTenPK.TabIndex = 4;
            // 
            // dtNgayLap
            // 
            this.dtNgayLap.CustomFormat = "dd-MM-yyyy ";
            this.dtNgayLap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayLap.Location = new System.Drawing.Point(303, 22);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Size = new System.Drawing.Size(303, 27);
            this.dtNgayLap.TabIndex = 3;
            // 
            // radbttTatCa
            // 
            this.radbttTatCa.AutoSize = true;
            this.radbttTatCa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbttTatCa.Location = new System.Drawing.Point(225, 26);
            this.radbttTatCa.Name = "radbttTatCa";
            this.radbttTatCa.Size = new System.Drawing.Size(70, 23);
            this.radbttTatCa.TabIndex = 2;
            this.radbttTatCa.TabStop = true;
            this.radbttTatCa.Text = "Tất cả";
            this.radbttTatCa.UseVisualStyleBackColor = true;
            this.radbttTatCa.CheckedChanged += new System.EventHandler(this.radbttTatCa_CheckedChanged);
            // 
            // radbttDaKham
            // 
            this.radbttDaKham.AutoSize = true;
            this.radbttDaKham.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbttDaKham.Location = new System.Drawing.Point(119, 26);
            this.radbttDaKham.Name = "radbttDaKham";
            this.radbttDaKham.Size = new System.Drawing.Size(90, 23);
            this.radbttDaKham.TabIndex = 1;
            this.radbttDaKham.TabStop = true;
            this.radbttDaKham.Text = "Đã khám";
            this.radbttDaKham.UseVisualStyleBackColor = true;
            this.radbttDaKham.CheckedChanged += new System.EventHandler(this.radbttDaKham_CheckedChanged);
            // 
            // radbttChuaKham
            // 
            this.radbttChuaKham.AutoSize = true;
            this.radbttChuaKham.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbttChuaKham.Location = new System.Drawing.Point(5, 26);
            this.radbttChuaKham.Name = "radbttChuaKham";
            this.radbttChuaKham.Size = new System.Drawing.Size(108, 23);
            this.radbttChuaKham.TabIndex = 0;
            this.radbttChuaKham.TabStop = true;
            this.radbttChuaKham.Text = "Chưa khám";
            this.radbttChuaKham.UseVisualStyleBackColor = true;
            this.radbttChuaKham.CheckedChanged += new System.EventHandler(this.radbttChuaKham_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(272, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(304, 29);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "PHÒNG CHỜ KHÁM BỆNH";
            // 
            // lsvCT
            // 
            this.lsvCT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaPhieuKB,
            this.colHoTenBN,
            this.colLoaiKham,
            this.colTinhTrang});
            this.lsvCT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvCT.FullRowSelect = true;
            this.lsvCT.GridLines = true;
            this.lsvCT.HideSelection = false;
            this.lsvCT.Location = new System.Drawing.Point(12, 118);
            this.lsvCT.MultiSelect = false;
            this.lsvCT.Name = "lsvCT";
            this.lsvCT.Size = new System.Drawing.Size(876, 281);
            this.lsvCT.TabIndex = 1;
            this.lsvCT.TabStop = false;
            this.lsvCT.UseCompatibleStateImageBehavior = false;
            this.lsvCT.View = System.Windows.Forms.View.Details;
            // 
            // colMaPhieuKB
            // 
            this.colMaPhieuKB.Text = "Mã phiếu khám bệnh";
            this.colMaPhieuKB.Width = 200;
            // 
            // colHoTenBN
            // 
            this.colHoTenBN.Text = "Họ tên bệnh nhân";
            this.colHoTenBN.Width = 200;
            // 
            // colLoaiKham
            // 
            this.colLoaiKham.Text = "Loại khám";
            this.colLoaiKham.Width = 200;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.Text = "Tình Trạng khám";
            this.colTinhTrang.Width = 150;
            // 
            // bttThoat
            // 
            this.bttThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.Location = new System.Drawing.Point(801, 421);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(87, 41);
            this.bttThoat.TabIndex = 6;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = true;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // bttXem
            // 
            this.bttXem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXem.Location = new System.Drawing.Point(12, 421);
            this.bttXem.Name = "bttXem";
            this.bttXem.Size = new System.Drawing.Size(87, 41);
            this.bttXem.TabIndex = 5;
            this.bttXem.Text = "Xem";
            this.bttXem.UseVisualStyleBackColor = true;
            this.bttXem.Click += new System.EventHandler(this.bttXem_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(304, 432);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(123, 19);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Tổng bệnh nhân:";
            // 
            // lbT
            // 
            this.lbT.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbT.Appearance.Options.UseFont = true;
            this.lbT.Location = new System.Drawing.Point(433, 432);
            this.lbT.Name = "lbT";
            this.lbT.Size = new System.Drawing.Size(94, 19);
            this.lbT.TabIndex = 8;
            this.lbT.Text = "labelControl3";
            this.lbT.Click += new System.EventHandler(this.lbT_Click);
            // 
            // FrmPhongCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 474);
            this.Controls.Add(this.lbT);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.bttXem);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.lsvCT);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmPhongCho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng chờ";
            this.Load += new System.EventHandler(this.FrmPhongCho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cbbTenPK;
        private System.Windows.Forms.DateTimePicker dtNgayLap;
        private System.Windows.Forms.RadioButton radbttTatCa;
        private System.Windows.Forms.RadioButton radbttDaKham;
        private System.Windows.Forms.RadioButton radbttChuaKham;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ListView lsvCT;
        private System.Windows.Forms.ColumnHeader colMaPhieuKB;
        private System.Windows.Forms.ColumnHeader colHoTenBN;
        private System.Windows.Forms.ColumnHeader colLoaiKham;
        private System.Windows.Forms.ColumnHeader colTinhTrang;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.Button bttXem;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lbT;
    }
}