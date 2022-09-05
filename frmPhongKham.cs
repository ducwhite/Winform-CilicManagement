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
    public partial class frmPhongKham : DevExpress.XtraEditors.XtraForm
    {
        bool Edit;
        public bool themmoi = true;
        Model1 dbcontext = new Model1();
        public frmPhongKham()
        {
            InitializeComponent();
        }

        private void frmPhongKham_Load(object sender, EventArgs e)
        {
            List<PHONGKHAM> lists = dbcontext.PHONGKHAMs.ToList();
            render(lists);
            setNull();
            setButton(true);
            setKhoa(true);
        }
        public void setNull()
        {
            txtMapk.Text = "";
            txtTenPk.Text = "";
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
            txtMapk.ReadOnly = bl;
            txtTenPk.ReadOnly = bl;
        }
        public void render(List<PHONGKHAM> pHONGKHAMs)
        {
            Model1 context = new Model1();
            List<PHONGKHAM> Listdt = context.PHONGKHAMs.ToList();
            lsvphongkham.Items.Clear();
            foreach (var item in Listdt)
            {
                ListViewItem listItem = new ListViewItem(item.MAPK);
                listItem.SubItems.Add(item.TENPK);
                lsvphongkham.Items.Add(listItem);
            }
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            Edit = false;
            themmoi = true;
            setNull();
            setButton(false);
            setKhoa(false);
            txtMapk.Focus();
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn muốn xoa", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl == DialogResult.OK)
            {
                if (lsvphongkham.Items.Count > 0)
                {
                    string MAPK = lsvphongkham.SelectedItems[0].SubItems[0].Text;
                    PHONGKHAM pk  = dbcontext.PHONGKHAMs.FirstOrDefault(s => s.MAPK == MAPK);

                    //MessageBox.Show(MABN);
                    dbcontext.PHONGKHAMs.Remove(pk);
                    dbcontext.SaveChanges();
                    render(dbcontext.PHONGKHAMs.ToList());
                }
            }
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            Edit = true;
            if (lsvphongkham.SelectedItems.Count > 0)
            {

                themmoi = false;
                setButton(false);
                setKhoa(false);
            }
            else
                MessageBox.Show("Mời chọn dòng cần sửa", "Thông báo!", MessageBoxButtons.OK);
            txtMapk.ReadOnly = true;
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (KTnhap()==false)
            {
                if (Edit&&themmoi==false)
                {
                    PHONGKHAM pk = dbcontext.PHONGKHAMs.FirstOrDefault(s => s.MAPK == txtMapk.Text);
                    pk.TENPK = txtTenPk.Text;
                }
                else
                {
                    PHONGKHAM pk = new PHONGKHAM();
                    pk.MAPK = txtMapk.Text;
                    pk.TENPK = txtTenPk.Text;
                    dbcontext.PHONGKHAMs.Add(pk);
                }
                dbcontext.SaveChanges();
                render(dbcontext.PHONGKHAMs.ToList());
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

        private void lsvphongkham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvphongkham.SelectedItems.Count > 0)
            {
                txtMapk.Text = lsvphongkham.SelectedItems[0].SubItems[0].Text;
                txtTenPk.Text = lsvphongkham.SelectedItems[0].SubItems[1].Text;
            }
        }
        public bool KTnhap()
        {
            if (txtMapk.Text.Trim() == "" || txtTenPk.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (txtMapk.Text.Trim().Length != 5)
            {
                MessageBox.Show("Mã mã phòng khám phải có đúng 5 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (txtTenPk.Text.Length > 100)
            {
                MessageBox.Show("Tên chỉ nhập được tối đa 100 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung(txtMapk.Text, 0) == true&&themmoi==true)
            {
                MessageBox.Show("Bạn nhập đã trùng mã!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung(txtTenPk.Text, 1) == true)
            {
                MessageBox.Show("Bạn nhập đã trùng tên!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }

        int idex;
        private bool KTTrung(string str, int index)
        {
            for (int i = 0; i < lsvphongkham.Items.Count; i++)
            {
                if (i != idex && themmoi == false)
                {
                    if (lsvphongkham.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
                if (themmoi == true)
                {
                    if (lsvphongkham.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


    }
}