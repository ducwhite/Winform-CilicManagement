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
    public partial class frmtiemkiembacsy : DevExpress.XtraEditors.XtraForm
    {
        public frmtiemkiembacsy()
        {
            InitializeComponent();
        }
        bool Edit;
        public bool themmoi = false;
        Model1 dbcontext = new Model1();
        

      
        public void FillDataToComboBox1(List<KHOADIEUTRI> kHOADIEUTRIs)
        {
            cbbkdt.DataSource = kHOADIEUTRIs;
            cbbkdt.DisplayMember = "TENKHOA";
            cbbkdt.ValueMember = "MAKHOA";
            cbbkdt.SelectedIndex = -1;
        }
        public void FillDataToComboBox2(List<PHONGKHAM> pHONGKHAMs)
        {
            cbbpk.DataSource = pHONGKHAMs;
            cbbpk.DisplayMember = "TENPK";
            cbbpk.ValueMember = "MAPK";
            cbbpk.SelectedIndex = -1;
        }
        public void render(List<BACSY> bACSies)
        {
            //List<BACSY> list = dbcontext.BACSies.ToList();
            //List<KHOADIEUTRI> listss = dbcontext.KHOADIEUTRIs.ToList();
            //List<DANTOC> lists = dbcontext.DANTOCs.ToList();
            //List<PHONGKHAM> lis = dbcontext.PHONGKHAMs.ToList();
            listView1.Items.Clear();
            foreach (var item in bACSies)
            {
                ListViewItem listItem = new ListViewItem(item.MABS);
                listItem.SubItems.Add(item.TENBS);
                listItem.SubItems.Add(item.NGAYSINH.ToString());
                listItem.SubItems.Add(item.GIOITINH);
                listItem.SubItems.Add(item.SDT);
                listItem.SubItems.Add(item.DANTOC.TENDT);
                listItem.SubItems.Add(item.KHOADIEUTRI.TENKHOA);
                listItem.SubItems.Add(item.PHONGKHAM.TENPK);
                listView1.Items.Add(listItem);
            }
        }
        private void frmtiemkiembacsy_Load(object sender, EventArgs e)
        {
            List<BACSY> list = dbcontext.BACSies.ToList();
            List<KHOADIEUTRI> listss = dbcontext.KHOADIEUTRIs.ToList();
            List<DANTOC> lists = dbcontext.DANTOCs.ToList();
            List<PHONGKHAM> lis = dbcontext.PHONGKHAMs.ToList();
    
            FillDataToComboBox1(listss);
            FillDataToComboBox2(lis);
            render(list);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<BACSY> listsearch = dbcontext.BACSies
                .Where(p => (string.IsNullOrEmpty(txtmabs.Text) || p.MABS.Contains(txtmabs.Text))
                && (string.IsNullOrEmpty(txttenbs.Text) || p.TENBS.Contains(txttenbs.Text))
                && (string.IsNullOrEmpty(txtdienthoai.Text) || p.SDT.Contains(txtdienthoai.Text))
                && (string.IsNullOrEmpty(cbbkdt.Text) || p.KHOADIEUTRI.TENKHOA.Contains(cbbkdt.Text))
                && (string.IsNullOrEmpty(cbbpk.Text) || p.PHONGKHAM.TENPK.Contains(cbbkdt.Text)))
                .ToList();
            render(listsearch);
            txtsoluong.Text = listsearch.Count().ToString();
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}