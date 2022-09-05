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
    public partial class frmLoaikham : DevExpress.XtraEditors.XtraForm
    {

        public frmLoaikham()
        {
            InitializeComponent();
        }

        private void frmLoaikham_Load(object sender, EventArgs e)
        {
            List<LOAIKHAM> lists = dbcontext.LOAIKHAMs.ToList();
            render(lists);
            setNull();
            setButton(true);
            setKhoa(true);
        }
        bool Edit;
        public bool themmoi = false;
        Model1 dbcontext = new Model1();
        

        
        public void setNull()
        {
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
            txtgia.Text = "";
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
            txtMaLoai.ReadOnly = bl;
            txtTenLoai.ReadOnly = bl;
            txtgia.ReadOnly = bl;

        }


        public void render(List<LOAIKHAM> lOAIKHAMs)
        {


            Model1 context = new Model1();

            List<LOAIKHAM> Listdt = context.LOAIKHAMs.ToList();
            lsvLoaiKham.Items.Clear();
            foreach (var item in Listdt)
            {
                ListViewItem listItem = new ListViewItem(item.MALOAIK);

                listItem.SubItems.Add(item.TEN);
                listItem.SubItems.Add(item.GIA.ToString());

                lsvLoaiKham.Items.Add(listItem);
            }
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            Edit = false;
            themmoi = true;
            setNull();
            setButton(false);
            setKhoa(false);
            txtMaLoai.Focus();
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn muốn xoa", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl == DialogResult.OK)
            {
                if (lsvLoaiKham.Items.Count > 0)
                {
                    string MALK = lsvLoaiKham.SelectedItems[0].SubItems[0].Text;
                    LOAIKHAM lk = dbcontext.LOAIKHAMs.FirstOrDefault(s => s.MALOAIK == MALK);

                    //MessageBox.Show(MABN);
                    dbcontext.LOAIKHAMs.Remove(lk);
                    dbcontext.SaveChanges();
                    render(dbcontext.LOAIKHAMs.ToList());
                }
            }
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            Edit = true;
            if (lsvLoaiKham.SelectedItems.Count > 0)
            {

                themmoi = false;
                setButton(false);
                setKhoa(false);
            }
            else
                MessageBox.Show("Mời chọn dòng cần sửa", "Thông báo!", MessageBoxButtons.OK);
            txtMaLoai.ReadOnly = true;
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (KTnhap()==false)
            {
                if (Edit&&themmoi==false)
                {
                    LOAIKHAM dt = dbcontext.LOAIKHAMs.FirstOrDefault(s => s.MALOAIK == txtMaLoai.Text);
                    dt.TEN = txtTenLoai.Text;
                    dt.GIA = decimal.Parse(txtgia.Text);
                }
                else
                {
                    LOAIKHAM dt = new LOAIKHAM();
                    dt.MALOAIK = txtMaLoai.Text;
                    dt.TEN = txtTenLoai.Text;
                    dt.GIA = decimal.Parse(txtgia.Text);
                    dbcontext.LOAIKHAMs.Add(dt);
                }
                dbcontext.SaveChanges();
                render(dbcontext.LOAIKHAMs.ToList());
                setNull();
                setKhoa(true);
                setButton(true);
            }
        }

        private void bttHuy_Click_1(object sender, EventArgs e)
        {
            setButton(true);
            setNull();
            setKhoa(true);
        }

        private void bttThoat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Yes để thoát !", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void lsvLoaiKham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvLoaiKham.SelectedItems.Count > 0)

            {
               txtMaLoai.Text = lsvLoaiKham.SelectedItems[0].SubItems[0].Text;
               txtTenLoai.Text = lsvLoaiKham.SelectedItems[0].SubItems[1].Text;
                txtgia.Text = lsvLoaiKham.SelectedItems[0].SubItems[2].Text;
            }
        }
        public bool KTnhap()
        {
            if (txtMaLoai.Text.Trim() == "" || txtTenLoai.Text.Trim() == "" || txtgia.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (txtMaLoai.Text.Trim().Length != 5)
            {
                MessageBox.Show("Mã loại khám phải có đúng 5 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (txtTenLoai.Text.Length > 100)
            {
                MessageBox.Show("Tên chỉ nhập được tối đa 100 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung(txtMaLoai.Text, 0) == true&&themmoi==true)
            {
                MessageBox.Show("Bạn nhập đã trùng mã!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung(txtTenLoai.Text, 1) == true)
            {
                MessageBox.Show("Bạn nhập đã trùng tên!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
   
            return false;
        }

        int idex;
        private bool KTTrung(string str, int index)
        {
            for (int i = 0; i < lsvLoaiKham.Items.Count; i++)
            {
                if (i != idex && themmoi == false)
                {
                    if (lsvLoaiKham.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
                if (themmoi == true)
                {
                    if (lsvLoaiKham.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}