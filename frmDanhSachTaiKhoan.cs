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
    public partial class frmDanhSachTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        Model1 dbcontext = new Model1();
        public frmDanhSachTaiKhoan()
        {
            InitializeComponent();
        }

        public void fillDataToListView(List<TAIKHOAN> tAIKHOANs)
        {
            List<TAIKHOAN> listTK = dbcontext.TAIKHOANs.ToList();
            listView1.Items.Clear();

            foreach (var item in listTK)
            {
                ListViewItem listItem = new ListViewItem(item.TENTK);

                listItem.SubItems.Add(item.MATKHAUTK);
                listItem.SubItems.Add(item.QUYENTK);

                listView1.Items.Add(listItem);
            }
        }

        private void frmDanhSachTaiKhoan_Load(object sender, EventArgs e)
        {
            List<TAIKHOAN> listTK = dbcontext.TAIKHOANs.ToList();
            fillDataToListView(listTK);
        }
    }
}