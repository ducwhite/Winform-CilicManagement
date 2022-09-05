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

    public partial class frmDSBN : DevExpress.XtraEditors.XtraForm
    {
        bool Edit;
        public bool themmoi = false;
        Model1 dbcontext = new Model1();
        public frmDSBN()
        {
            InitializeComponent();
        }

        private void frmDSBN_Load(object sender, EventArgs e)
        {
            List<BENHNHAN> list = dbcontext.BENHNHANs.ToList();

            List<DANTOC> lists = dbcontext.DANTOCs.ToList();
            FillDataToComboBox(lists);
            render(list);
            setNull();
            setButton(true);
            setKhoa(true);
        }
        public void setNull()
        {
            txtmabn.Text = "";
            txthoten.Text = "";
            dtngaysinh.Text = "";
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
            txtnghenghiep.Text = "";
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
            txtmabn.ReadOnly = bl;
            txthoten.ReadOnly = bl;
            dtngaysinh.Enabled = !bl;
            txtdiachi.ReadOnly = bl;
            txtdienthoai.ReadOnly = bl;
            txtnghenghiep.ReadOnly = bl;
            cbbdantoc.Enabled = !bl;
            radiobtnam.Enabled = !bl;
            radiobtnu.Enabled = !bl;
        }
       
        public void FillDataToComboBox(List<DANTOC> dANTOCs)

        {
            cbbdantoc.DataSource = dANTOCs;
            cbbdantoc.DisplayMember = "TENDT";
            cbbdantoc.ValueMember = "MADT";

        }
        public void render(List<BENHNHAN> bENHNHANs)
        {


            Model1 context = new Model1();
            List<BENHNHAN> Listbn = context.BENHNHANs.ToList();
            List<DANTOC> Listdt = context.DANTOCs.ToList();
            listView1.Items.Clear();
            foreach (var item in Listbn)
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

        private void bttThem_Click(object sender, EventArgs e)
        {
            Edit = false;
            themmoi = true;
            setNull();
            setButton(false);
            setKhoa(false);
            txtmabn.Focus();
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
            txtmabn.ReadOnly = true;
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (KTnhap()==false)
            {
                if (Edit&&themmoi==false)
                {
                    BENHNHAN bn = dbcontext.BENHNHANs.FirstOrDefault(s => s.MABN == txtmabn.Text);
                    bn.TENBN = txthoten.Text;
                    string GT = "Nam";
                    if (radiobtnu.Checked)
                    {
                        GT = "Nữ";
                    }
                    bn.GIOITINH = GT;
                    bn.NGAYSINH = dtngaysinh.Value.Date;
                    bn.DIACHI = txtdiachi.Text;
                    bn.SDT = txtdienthoai.Text;
                    bn.MADT = cbbdantoc.SelectedValue.ToString();
                    bn.NGHENGHIEP = txtnghenghiep.Text;
                }
                else
                {
                    BENHNHAN bn = new BENHNHAN();
                    bn.MABN = txtmabn.Text;
                    bn.TENBN = txthoten.Text;
                    string GT = "Nam";
                    if (radiobtnu.Checked)
                    {
                        GT = "Nữ";
                    }
                    bn.GIOITINH = GT;
                    bn.NGAYSINH = DateTime.Parse(dtngaysinh.Text);
                    bn.DIACHI = txtdiachi.Text;
                    bn.SDT = txtdienthoai.Text;
                    bn.NGAYSINH = dtngaysinh.Value.Date;
                    bn.NGHENGHIEP = txtnghenghiep.Text;
                    dbcontext.BENHNHANs.Add(bn);
                }
                dbcontext.SaveChanges();
                render(dbcontext.BENHNHANs.ToList());
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

        private void bttXoa_Click(object sender, EventArgs e)
        {

            DialogResult dl = MessageBox.Show("Bạn muốn xoa", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl == DialogResult.OK)
            {
                if (listView1.Items.Count > 0)
                {
                    string MABN = listView1.SelectedItems[0].SubItems[0].Text;
                    BENHNHAN bn = dbcontext.BENHNHANs.FirstOrDefault(s => s.MABN==MABN);
                    
                        //MessageBox.Show(MABN);
                    dbcontext.BENHNHANs.Remove(bn);
                    dbcontext.SaveChanges();
                    render(dbcontext.BENHNHANs.ToList());
                }
            }
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
                txtmabn.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txthoten.Text = listView1.SelectedItems[0].SubItems[1].Text;
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
                txtnghenghiep.Text = listView1.SelectedItems[0].SubItems[7].Text;
            }
        }
        public bool KTnhap()
        {
            if (txtmabn.Text.Trim() == "" || txthoten.Text.Trim() == "" || txtdiachi.Text.Trim() == "" || txtdienthoai.Text.Trim() == "" || txtnghenghiep.Text.Trim() == "" || cbbdantoc.Text.Trim() == "" || dtngaysinh.Text.Trim() == "" || radiobtnam.Text.Trim() == "" || radiobtnu.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (txtmabn.Text.Trim().Length != 5)
            {
                MessageBox.Show("Mã thuốc phải có đúng 5 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (txthoten.Text.Length > 40)
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
            if (txtnghenghiep.Text.Length > 30)
            {
                MessageBox.Show("nghề nghiệp chỉ nhập được tối đa 30 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }

            if (KTTrung(txtmabn.Text, 0) == true&&themmoi==true)
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
