using DevExpress.XtraEditors;
using Quanlyphongkham.model;
using QUANLYPHONGKHAMTU.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Quanlyphongkham
{
    public partial class frmtimkiemthuoc : DevExpress.XtraEditors.XtraForm
    {
        public frmtimkiemthuoc()
        {
            InitializeComponent();
        }
        Model1 dbcontext = new Model1();
        private void bttThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                List<THUOC> listsearch = dbcontext.THUOCs
                    .Where(p => (string.IsNullOrEmpty(txtMaSo.Text) || p.MATHUOC.Contains(txtMaSo.Text))
                    && (string.IsNullOrEmpty(txtTenThuoc.Text) || p.TEN.Contains(txtTenThuoc.Text))
                    && (string.IsNullOrEmpty(cbbTenL.Text) || p.LOAITHUOC.TENLOAI.Contains(cbbTenL.Text)))
                    .ToList();
            HienThiThuoc(listsearch);
            txtsoluong.Text = listsearch.Count().ToString();
            setNull();

        }
        public void HienThiThuoc(List<THUOC>tHUOCs)
        {
            lsvThuoc.Items.Clear();
            foreach (var item in tHUOCs)
            {
                ListViewItem listItem = new ListViewItem(item.MATHUOC);
                listItem.SubItems.Add(item.TEN);
                listItem.SubItems.Add(item.SOLUONG.ToString());
                listItem.SubItems.Add(item.DONGIA.ToString());
                listItem.SubItems.Add(item.DONVITINH);
                listItem.SubItems.Add(item.LOAITHUOC.TENLOAI);
                lsvThuoc.Items.Add(listItem);
            }
        }
        void HienthiLoaiThuoc(List<LOAITHUOC>lOAITHUOCs)
        {
            
            cbbTenL.DataSource = lOAITHUOCs;
            cbbTenL.DisplayMember = "TENLOAI";
            cbbTenL.ValueMember = "MALOAI";
            cbbTenL.SelectedIndex = -1;
        }
        private void frmtimkiemthuoc_Load(object sender, EventArgs e)
        {
            List<THUOC> Listt = dbcontext.THUOCs.ToList();
            List<LOAITHUOC> Listlt = dbcontext.LOAITHUOCs.ToList();
            HienThiThuoc(Listt);
            HienthiLoaiThuoc(Listlt);
        }

        public void setNull()
        {
            txtMaSo.Text = "";
            txtTenThuoc.Text = "";
            cbbTenL.Text = "";
        }
    }
}