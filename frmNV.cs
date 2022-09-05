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
    public partial class frmNV : DevExpress.XtraEditors.XtraForm
    {
        
        bool Edit;
        public bool themmoi = false;
        Model1 dbcontext = new Model1();
        public frmNV()
        {
            InitializeComponent();
        }

        private void frmNV_Load(object sender, EventArgs e)
        {
            List<NV> list = dbcontext.NVs.ToList();
            List<CHUCVU> listss = dbcontext.CHUCVUs.ToList();
            List<DANTOC> lists = dbcontext.DANTOCs.ToList();
            FillDataToComboBox(lists);
            FillDataToComboBox1(listss);
            render(list);
            setNull();
            setButton(true);
            setKhoa(true);
        }
        public void setNull()
        {
            txtmanv.Text = "";
            txttennv.Text = "";
            dtngaysinh.Text = "";
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
            cbbchucvu.Text = "";
            cbbdantoc.Text = "";
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
            radiobtnam.Enabled = !bl;
            radiobtnu.Enabled = !bl;
            txtmanv.ReadOnly = bl;
            txttennv.ReadOnly = bl;
            dtngaysinh.Enabled= !bl;
            txtdiachi.ReadOnly = bl;
            txtdienthoai.ReadOnly = bl;
            cbbchucvu.Enabled = !bl;
            cbbdantoc.Enabled = !bl;
        }

        public void FillDataToComboBox(List<DANTOC> dANTOCs)

        {
            cbbdantoc.DataSource = dANTOCs;
            cbbdantoc.DisplayMember = "TENDT";
            cbbdantoc.ValueMember = "MADT";

        }
        public void FillDataToComboBox1(List<CHUCVU> cHUCVUs)

        {
            cbbchucvu.DataSource = cHUCVUs;
            cbbchucvu.DisplayMember = "TENCV";
            cbbchucvu.ValueMember = "MACV";

        }
        public void render(List<NV> nVs)
        {
            
            List<NV> Listnv = dbcontext.NVs.ToList();
            List<DANTOC> Listdt = dbcontext.DANTOCs.ToList();
            List<CHUCVU> Listcv = dbcontext.CHUCVUs.ToList();
            listView1.Items.Clear();
            foreach (var item in Listnv)
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
        private void bttThem_Click(object sender, EventArgs e)
        {
            Edit = false;
            themmoi = true;
            setNull();
            setButton(false);
            setKhoa(false);
            txtmanv.Focus();
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn muốn xoa", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl == DialogResult.OK)
            {
                if (listView1.Items.Count > 0)
                {
                    string MANV = listView1.SelectedItems[0].SubItems[0].Text;
                    NV nv = dbcontext.NVs.FirstOrDefault(s => s.MANV == MANV);

                    //MessageBox.Show(MABN);
                    dbcontext.NVs.Remove(nv);
                    dbcontext.SaveChanges();
                    render(dbcontext.NVs.ToList());
                }
            }
           
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            Edit = true;
            if (listView1.SelectedItems.Count > 0)
            {

                themmoi = false;
                setButton(false);
                setKhoa(false);
            }
            else
                MessageBox.Show("Mời chọn dòng cần sửa", "Thông báo!", MessageBoxButtons.OK);
            txtmanv.ReadOnly = true;
        }
      

        

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (KTnhap()==false)
            {
                if (Edit&&themmoi==false)
                {
                    NV nv = dbcontext.NVs.FirstOrDefault(s => s.MANV == txtmanv.Text);
                    nv.TENNV = txttennv.Text;
                    string GT = "Nam";
                    if (radiobtnu.Checked)
                    {
                        GT = "Nữ";

                    }
                    nv.GIOITINH = GT;
                    nv.NAMSINH = dtngaysinh.Value.Date;
                    nv.DIACHI = txtdiachi.Text;
                    nv.SDT = txtdienthoai.Text;
                    nv.MADT = cbbdantoc.SelectedValue.ToString();
                    nv.MACV = cbbchucvu.SelectedValue.ToString();

                }
                else
                {
                    NV nv = new NV();
                    nv.MANV = txtmanv.Text;
                    nv.TENNV = txttennv.Text;
                    string GT = "Nam";
                    if (radiobtnu.Checked)
                    {
                        GT = "Nữ";

                    }
                    nv.GIOITINH = GT;
                    nv.NAMSINH = dtngaysinh.Value.Date;
                    nv.DIACHI = txtdiachi.Text;
                    nv.SDT = txtdienthoai.Text;
                    nv.MADT = cbbdantoc.SelectedValue.ToString();
                    nv.MACV = cbbchucvu.SelectedValue.ToString();
                    dbcontext.NVs.Add(nv);
                }
                dbcontext.SaveChanges();
                render(dbcontext.NVs.ToList());
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)

            {
                txtmanv.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txttennv.Text = listView1.SelectedItems[0].SubItems[1].Text;
                dtngaysinh.Text = listView1.SelectedItems[0].SubItems[2].Text;

                if (listView1.SelectedItems[0].SubItems[3].Text == "Nam")
                {
                    radiobtnam.Checked = true;
                }
                else
                {
                    radiobtnu.Checked = true;

                }
                txtdiachi.Text = listView1.SelectedItems[0].SubItems[4].Text;
                txtdienthoai.Text = listView1.SelectedItems[0].SubItems[5].Text;
                cbbdantoc.Text = listView1.SelectedItems[0].SubItems[6].Text;
                cbbchucvu.Text = listView1.SelectedItems[0].SubItems[7].Text;
            }
        }
        public bool KTnhap()
        {
            if (txtmanv.Text.Trim() == "" || txttennv.Text.Trim() == "" || txtdiachi.Text.Trim() == "" || txtdienthoai.Text.Trim() == "" || cbbchucvu.Text.Trim() == "" || cbbdantoc.Text.Trim() == "" || dtngaysinh.Text.Trim() == "" || radiobtnam.Text.Trim() == "" || radiobtnu.Text.Trim() =="" )
            {
                MessageBox.Show("Không được để trống!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (txtmanv.Text.Trim().Length != 5)
            {
                MessageBox.Show("Mã thuốc phải có đúng 5 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (txttennv.Text.Length > 40)
            {
                MessageBox.Show("Tên chỉ nhập được tối đa 40 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (txtdiachi.Text.Length > 100)
            {
                MessageBox.Show("địa chỉ chỉ nhập được tối đa 100 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (txtdienthoai.Text.Length > 10)
            {
                MessageBox.Show("điện thoại chỉ nhập được tối đa 10 số!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (DateTime.Now.Year - dtngaysinh.Value.Year < 18)
            {
                MessageBox.Show("chưa đủ yêu cầu 18 tuổi!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }

            if (KTTrung(txtmanv.Text, 0) == true&&themmoi==true)
            {
                MessageBox.Show(" bạn nhập mã đã trùng!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }

        int idex;
        private bool KTTrung(string str, int index)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (i != idex && themmoi == false)
                {
                    if (listView1.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
                if (themmoi == true)
                {
                    if (listView1.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}