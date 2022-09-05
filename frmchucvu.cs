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

namespace QUANLYPHONGKHAMTU
{
    public partial class frmchucvu : DevExpress.XtraEditors.XtraForm
    {
        bool Edit;
        public bool themmoi = false;
        Model1 dbcontext = new Model1();
        public frmchucvu()
        {
            InitializeComponent();
        }

        private void frmchucvu_Load(object sender, EventArgs e)
        {
            List<CHUCVU> lists = dbcontext.CHUCVUs.ToList();
            render(lists);
            setNull();
            setButton(true);
            setKhoa(true);
        }
        public void setNull()
        {
            txtmacv.Text = "";
            txttencv.Text = "";
        }

        void setButton(bool bl)
        {
            bttThem.Enabled = bl;
            bttXoa.Enabled = bl;
            bttSua.Enabled = bl;
            bttThoat.Enabled = bl;
            bttLuu.Enabled = !bl;
            bttHuy.Enabled = !bl;
        }

        void setKhoa(bool bl)
        {
            txtmacv.ReadOnly = bl;
            txttencv.ReadOnly = bl;

        }


        public void render(List<CHUCVU> cHUCVUs)
        {


            Model1 context = new Model1();

            List<CHUCVU> List = context.CHUCVUs.ToList();
            lsvchucvu.Items.Clear();
            foreach (var item in List)
            {
                ListViewItem listItem = new ListViewItem(item.MACV);

                listItem.SubItems.Add(item.TENCV);

                lsvchucvu.Items.Add(listItem);
            }
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            Edit = false;
            themmoi = true;
            setNull();
            setButton(false);
            setKhoa(false);
            txtmacv.Focus();
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn muốn xoa", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl == DialogResult.OK)
            {
                if (lsvchucvu.Items.Count > 0)
                {
                    string MACV = lsvchucvu.SelectedItems[0].SubItems[0].Text;
                    CHUCVU dt = dbcontext.CHUCVUs.FirstOrDefault(s => s.MACV== MACV);

                    //MessageBox.Show(MABN);
                    dbcontext.CHUCVUs.Remove(dt);
                    dbcontext.SaveChanges();
                    render(dbcontext.CHUCVUs.ToList());
                }
            }
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            Edit = true;
            if (lsvchucvu.SelectedItems.Count > 0)
            {

                themmoi = false;
                setButton(false);
                setKhoa(false);
            }
            else
                MessageBox.Show("Mời chọn dòng cần sửa", "Thông báo!", MessageBoxButtons.OK);
            txtmacv.ReadOnly = true;
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (KTnhap()==false)
            {
                if (Edit&&themmoi==false)
                {
                    CHUCVU dt = dbcontext.CHUCVUs.FirstOrDefault(s => s.MACV == txtmacv.Text);
                    dt.TENCV = txttencv.Text;
                }
                else
                {
                    CHUCVU dt = new CHUCVU();
                    dt.MACV = txtmacv.Text;
                    dt.TENCV = txttencv.Text;
                    dbcontext.CHUCVUs.Add(dt);
                }
                dbcontext.SaveChanges();
                render(dbcontext.CHUCVUs.ToList());
                setNull();
                setKhoa(true);
                setButton(true);

            }
        }

        private void bttHuy_Click(object sender, EventArgs e)
        {
            setButton(true);
            setNull();
            setKhoa(true);
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không ?", "Yes để thoát !", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void lsvchucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvchucvu.SelectedItems.Count > 0)

            {
                txtmacv.Text = lsvchucvu.SelectedItems[0].SubItems[0].Text;
                txttencv.Text = lsvchucvu.SelectedItems[0].SubItems[1].Text;
            }
        }
        public bool KTnhap()
        {
            if (txtmacv.Text.Trim() == "" || txttencv.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (txtmacv.Text.Trim().Length != 2)
            {
                MessageBox.Show("Mã chức vụ phải có đúng 2 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (txttencv.Text.Length > 50)
            {
                MessageBox.Show("Tên chỉ nhập được tối đa 50 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung(txtmacv.Text, 0) == true&&themmoi==true)
            {
                MessageBox.Show("Bạn nhập đã trùng mã!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung(txttencv.Text, 1) == true)
            {
                MessageBox.Show("Bạn nhập đã trùng tên!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }
        int idex;
        private bool KTTrung(string str, int index)
        {
            for (int i = 0; i < lsvchucvu.Items.Count; i++)
            {
                if (i != idex && themmoi == false)
                {
                    if (lsvchucvu.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
                if (themmoi == true)
                {
                    if (lsvchucvu.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}