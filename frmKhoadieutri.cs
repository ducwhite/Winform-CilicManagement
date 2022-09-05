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

namespace QUANLYPHONGKHAMTU
{
    public partial class frmKhoadieutri : DevExpress.XtraEditors.XtraForm
    {
        bool Edit;
        public bool themmoi = false;
        Model1 dbcontext = new Model1();
        public frmKhoadieutri()
        {
            InitializeComponent();
        }

        private void frmKhoadieutri_Load(object sender, EventArgs e)
        {
            List<KHOADIEUTRI> lists = dbcontext.KHOADIEUTRIs.ToList();
            render(lists);
            setNull();
            setButton(true);
            setKhoa(true);
        }
        public void setNull()
        {
            txtMakhoa.Text = "";
            txtTenKhoa.Text = "";
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
            txtMakhoa.ReadOnly = bl;
            txtTenKhoa.ReadOnly = bl;

        }


        public void render(List<KHOADIEUTRI> kHOADIEUTRIs)
        {


            Model1 context = new Model1();

            List<KHOADIEUTRI> Listdt = context.KHOADIEUTRIs.ToList();
            lsvkhoadieutri.Items.Clear();
            foreach (var item in Listdt)
            {
                ListViewItem listItem = new ListViewItem(item.MAKHOA);

                listItem.SubItems.Add(item.TENKHOA);

                lsvkhoadieutri.Items.Add(listItem);
            }
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            Edit = false;
            themmoi = true;
            setNull();
            setButton(false);
            setKhoa(false);
            txtMakhoa.Focus();
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn muốn xoa", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl == DialogResult.OK)
            {
                if (lsvkhoadieutri.Items.Count > 0)
                {
                    string MAK = lsvkhoadieutri.SelectedItems[0].SubItems[0].Text;
                    KHOADIEUTRI dt = dbcontext.KHOADIEUTRIs.FirstOrDefault(s => s.MAKHOA == MAK);

                    //MessageBox.Show(MABN);
                    dbcontext.KHOADIEUTRIs.Remove(dt);
                    dbcontext.SaveChanges();
                    render(dbcontext.KHOADIEUTRIs.ToList());
                }
            }
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            Edit = true;
            if (lsvkhoadieutri.SelectedItems.Count > 0)
            {

                themmoi = false;
                setButton(false);
                setKhoa(false);
            }
            else
                MessageBox.Show("Mời chọn dòng cần sửa", "Thông báo!", MessageBoxButtons.OK);
            txtMakhoa.ReadOnly = true;
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (KTnhap()==false)
            {
                if (Edit&&themmoi==false)
                {
                    KHOADIEUTRI dt = dbcontext.KHOADIEUTRIs.FirstOrDefault(s => s.MAKHOA == txtMakhoa.Text);
                    dt.TENKHOA = txtTenKhoa.Text;
                }
                else
                {
                    KHOADIEUTRI dt = new KHOADIEUTRI();
                    dt.MAKHOA = txtMakhoa.Text;
                    dt.TENKHOA = txtTenKhoa.Text;
                    dbcontext.KHOADIEUTRIs.Add(dt);
                }
                dbcontext.SaveChanges();
                render(dbcontext.KHOADIEUTRIs.ToList());
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
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Yes để thoát !", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void lsvLoaiThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvkhoadieutri.SelectedItems.Count > 0)

            {
                txtMakhoa.Text = lsvkhoadieutri.SelectedItems[0].SubItems[0].Text;
                txtTenKhoa.Text = lsvkhoadieutri.SelectedItems[0].SubItems[1].Text;
            }
        }
        public bool KTnhap()
        {
            if (txtMakhoa.Text.Trim() == "" || txtTenKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (txtMakhoa.Text.Trim().Length != 4)
            {
                MessageBox.Show("Mã dân tộc phải có đúng 4 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (txtTenKhoa.Text.Length > 100)
            {
                MessageBox.Show("Tên chỉ nhập được tối đa 100 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung(txtMakhoa.Text, 0) == true&&themmoi==true)
            {
                MessageBox.Show("Bạn nhập đã trùng mã!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung(txtTenKhoa.Text, 1) == true)
            {
                MessageBox.Show("Bạn nhập đã trùng tên!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }

        int idex;
        private bool KTTrung(string str, int index)
        {
            for (int i = 0; i < lsvkhoadieutri.Items.Count; i++)
            {
                if (i != idex && themmoi == false)
                {
                    if (lsvkhoadieutri.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
                if (themmoi == true)
                {
                    if (lsvkhoadieutri.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}