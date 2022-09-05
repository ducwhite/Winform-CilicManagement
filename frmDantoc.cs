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
    public partial class frmDantoc : DevExpress.XtraEditors.XtraForm
    {
        bool Edit;
        public bool themmoi = false;
        Model1 dbcontext = new Model1();
        public frmDantoc()
        {
            InitializeComponent();
        }

        private void frmDantoc_Load(object sender, EventArgs e)
        {
            List<DANTOC> lists = dbcontext.DANTOCs.ToList();   
            render(lists);
            setNull();
            setButton(true);
            setKhoa(true);
        }
        public void setNull()
        {
            txtmadt.Text = "";
            txttendt.Text = "";
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
            txtmadt.ReadOnly = bl;
            txttendt.ReadOnly = bl;
            
        }

        
        public void render(List<DANTOC> dANTOCs)
        {


            Model1 context = new Model1();
        
            List<DANTOC> Listdt = context.DANTOCs.ToList();
            lsvdantoc.Items.Clear();
            foreach (var item in Listdt)
            {
                ListViewItem listItem = new ListViewItem(item.MADT);

                listItem.SubItems.Add(item.TENDT);
                
                lsvdantoc.Items.Add(listItem);
            }
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            Edit = false;
            themmoi = true;
            setNull();
            setButton(false);
            setKhoa(false);
            txtmadt.Focus();
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn muốn xoa", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl == DialogResult.OK)
            {
                if (lsvdantoc.Items.Count > 0)
                {
                    string MADT = lsvdantoc.SelectedItems[0].SubItems[0].Text;
                    DANTOC dt = dbcontext.DANTOCs.FirstOrDefault(s => s.MADT == MADT);

                    //MessageBox.Show(MABN);
                    dbcontext.DANTOCs.Remove(dt);
                    dbcontext.SaveChanges();
                    render(dbcontext.DANTOCs.ToList());
                }
            }
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            Edit = true;
            if (lsvdantoc.SelectedItems.Count > 0)
            {

                themmoi = false;
                setButton(false);
                setKhoa(false);
            }
            else
                MessageBox.Show("Mời chọn dòng cần sửa", "Thông báo!", MessageBoxButtons.OK);
            txtmadt.ReadOnly = true;
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (KTnhap()==false)
            {
                if (Edit)
                     {
                         DANTOC dt = dbcontext.DANTOCs.FirstOrDefault(s => s.MADT == txtmadt.Text);
                          dt.TENDT = txttendt.Text;
                      }   
                 else
                 if (themmoi==true)
                {
                    {
                        DANTOC dt = new DANTOC();
                        dt.MADT = txtmadt.Text;
                        dt.TENDT = txttendt.Text;
                        dbcontext.DANTOCs.Add(dt);
                    }
                }
                      
                dbcontext.SaveChanges();
                render(dbcontext.DANTOCs.ToList());
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

        private void lsvdantoc_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lsvdantoc.SelectedItems.Count > 0)

            {
                txtmadt.Text = lsvdantoc.SelectedItems[0].SubItems[0].Text;
                txttendt.Text = lsvdantoc.SelectedItems[0].SubItems[1].Text;
            }
        }
        public bool KTnhap()
        {
            if (txtmadt.Text.Trim() == "" || txttendt.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (txtmadt.Text.Trim().Length != 4)
            {
                MessageBox.Show("Mã dân tộc phải có đúng 4 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (txttendt.Text.Length > 20)
            {
                MessageBox.Show("Tên chỉ nhập được tối đa 20 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung(txtmadt.Text, 0) == true && themmoi==true)
            {
                MessageBox.Show("Bạn nhập đã trùng mã!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (KTTrung(txttendt.Text, 1) == true)
            {
                MessageBox.Show("Bạn nhập đã trùng tên!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }
        int idex;
        private bool KTTrung(string str, int index)
        {
            for (int i = 0; i < lsvdantoc.Items.Count; i++)
            {
                if (i != idex && themmoi == false)
                {
                    if (lsvdantoc.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
                if (themmoi == true)
                {
                    if (lsvdantoc.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}