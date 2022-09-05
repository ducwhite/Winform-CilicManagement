using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Quanlyphongkham.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlyphongkham
{
    public partial class frmtiemkiembenhnhan : DevExpress.XtraEditors.XtraForm
    {
        bool Edit;
        public bool themmoi = false;
        Model1 dbcontext = new Model1();
        public frmtiemkiembenhnhan()
        {
            InitializeComponent();
        }

        private void frmtiemkiembenhnhan_Load(object sender, EventArgs e)
        {
            List<BENHNHAN> list = dbcontext.BENHNHANs.ToList();


            render(list);
        }
        
        public void render(List<BENHNHAN> bENHNHANs)
        {
        //    List<BENHNHAN> Listbn = dbcontext.BENHNHANs.ToList();
           // List<DANTOC> Listdt = dbcontext.DANTOCs.ToList();
            listView1.Items.Clear();
            foreach (var item in bENHNHANs)
            {
                ListViewItem listItem = new ListViewItem(item.MABN);

                listItem.SubItems.Add(item.TENBN);
                listItem.SubItems.Add(item.NGAYSINH.ToString());
                listItem.SubItems.Add(item.GIOITINH);
                listItem.SubItems.Add(item.DIACHI);
                listItem.SubItems.Add(item.SDT);
                listItem.SubItems.Add(item.DANTOC.TENDT);
                listItem.SubItems.Add(item.NGHENGHIEP);
                listView1.Items.Add(listItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showLoadingForm();

            listView1.Items.Clear();
            List<BENHNHAN> listsearch = dbcontext.BENHNHANs
                .Where(p => (string.IsNullOrEmpty(txtmabn.Text) || p.MABN.Contains(txtmabn.Text))
                && (string.IsNullOrEmpty(txthoten.Text) || p.TENBN.Contains(txthoten.Text))
                && (string.IsNullOrEmpty(txtdienthoai.Text) || p.SDT.Contains(txtdienthoai.Text)))
                .ToList();

            render(listsearch);
            txtsoluong.Text = listsearch.Count().ToString();

            //showLoadingForm();
            //listView1.Items.Clear();
            //List<BENHNHAN> listSearch = dbcontext.BENHNHANs.ToList();
            //List<BENHNHAN> listResult = new List<BENHNHAN>();
            //foreach (var item in listSearch)
            //{
            //    if (item.MABN.Equals(txtmabn.Text)||
            //    item.TENBN.Trim().ToLower().Contains(txthoten.Text.Trim().ToLower()) ||
            //    item.SDT.Trim().ToLower()==(txtdienthoai.Text.Trim().ToLower()))
            //    {
            //        listResult.Add(item);
            //    }
            //}

            //render(listResult);
            //txtsoluong.Text = listResult.Count().ToString();
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {

        }

        public void showLoadingForm()
        {
            SplashScreenManager.ShowForm(this, typeof(frmLoading), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("PHÒNG KHÁM HKDD...");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
            }
            SplashScreenManager.CloseForm();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)

            {
                txtmabn.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txthoten.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtdienthoai.Text = listView1.SelectedItems[0].SubItems[5].Text;
            }
        }
    }
}