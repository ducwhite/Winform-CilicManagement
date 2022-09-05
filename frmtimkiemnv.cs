using DevExpress.XtraEditors;
using Quanlyphongkham.model;
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
    public partial class frmtimkiemnv : DevExpress.XtraEditors.XtraForm
    {
        public frmtimkiemnv()
        {
            InitializeComponent();
        }

        bool Edit;
        public bool themmoi = false;
        Model1 dbcontext = new Model1();  
        
        public void FillDataToComboBox1(List<CHUCVU> cHUCVUs)

        {
            cbbchucvu.DataSource = cHUCVUs;
            cbbchucvu.DisplayMember = "TENCV";
            cbbchucvu.ValueMember = "MACV";
            cbbchucvu.SelectedIndex = -1;

        }
        public void render(List<NV> nVs)
        {

            //List<NV> Listnv = dbcontext.NVs.ToList();
            //List<DANTOC> Listdt = dbcontext.DANTOCs.ToList();
            //List<CHUCVU> Listcv = dbcontext.CHUCVUs.ToList();
            listView1.Items.Clear();
            foreach (var item in nVs)
            {
                ListViewItem listItem = new ListViewItem(item.MANV);
                listItem.SubItems.Add(item.TENNV);
                listItem.SubItems.Add(item.NAMSINH.ToString());
                listItem.SubItems.Add(item.GIOITINH);
                listItem.SubItems.Add(item.DIACHI);
                listItem.SubItems.Add(item.SDT);
                listItem.SubItems.Add(item.DANTOC.TENDT);
                listItem.SubItems.Add(item.CHUCVU.TENCV);
                listView1.Items.Add(listItem);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<NV> listsearch = dbcontext.NVs
                .Where(p => (string.IsNullOrEmpty(txtmanv.Text) || p.MANV.Contains(txtmanv.Text))
                && (string.IsNullOrEmpty(txttennv.Text) || p.TENNV.Contains(txttennv.Text))
                && (string.IsNullOrEmpty(txtdienthoai.Text) || p.SDT.Contains(txtdienthoai.Text))
                && (string.IsNullOrEmpty(cbbchucvu.Text) || p.CHUCVU.TENCV.Contains(cbbchucvu.Text)))
                .ToList();
            render(listsearch);
            txtsoluong.Text = listsearch.Count().ToString();
        }

        private void frmtimkiemnv_Load(object sender, EventArgs e)
        {
            List<NV> list = dbcontext.NVs.ToList();
            List<CHUCVU> listss = dbcontext.CHUCVUs.ToList();
            List<DANTOC> lists = dbcontext.DANTOCs.ToList();

            FillDataToComboBox1(listss);
            render(list);
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}