using DevExpress.XtraEditors;
using Quanlyphongkham.model;
//using QUANLYPHONGKHAMTU.model;
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
    public partial class frmbacsy : DevExpress.XtraEditors.XtraForm
    {
        bool Edit;
        int idex;
        public bool themmoi = false;
        Model1 dbcontext = new Model1();
        public frmbacsy()
        {
            InitializeComponent();
        }

        private void frmbacsy_Load(object sender, EventArgs e)
        {
            List<BACSY> list = dbcontext.BACSies.ToList();
            List<KHOADIEUTRI> listss = dbcontext.KHOADIEUTRIs.ToList();
            List<DANTOC> lists = dbcontext.DANTOCs.ToList();
            List<PHONGKHAM> lis = dbcontext.PHONGKHAMs.ToList();
            FillDataToComboBox(lists);
            FillDataToComboBox1(listss);
            FillDataToComboBox2(lis);
            render(list);
            setNull();
            setButton(true);
            setKhoa(true);
        }
        public void setNull()
        {
            txtmabs.Text = "";
            txttenbs.Text = "";
            dtngaysinh.Text = "";
            txtdienthoai.Text = "";
            cbbkdt.Text = "";
            cbbdantoc.Text = "";
            cbbpk.Text = "";
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
            txtmabs.ReadOnly = bl;
            txttenbs.ReadOnly = bl;
            dtngaysinh.Enabled = !bl;
            txtdienthoai.ReadOnly = bl;
            cbbkdt.Enabled = !bl;
            cbbdantoc.Enabled = !bl;
            cbbpk.Enabled = !bl;
        }

        public void FillDataToComboBox(List<DANTOC> dANTOCs)

        {
            cbbdantoc.DataSource = dANTOCs;
            cbbdantoc.DisplayMember = "TENDT";
            cbbdantoc.ValueMember = "MADT";

        }
        public void FillDataToComboBox1(List<KHOADIEUTRI> kHOADIEUTRIs)
        {
            cbbkdt.DataSource = kHOADIEUTRIs;
            cbbkdt.DisplayMember = "TENKHOA";
            cbbkdt.ValueMember = "MAKHOA";
        }
        public void FillDataToComboBox2(List<PHONGKHAM> pHONGKHAMs)
        {
            cbbpk.DataSource = pHONGKHAMs;
            cbbpk.DisplayMember = "TENPK";
            cbbpk.ValueMember = "MAPK";
        }
        public void render(List<BACSY> bACSies)
        {
            List<BACSY> list = dbcontext.BACSies.ToList();
            List<KHOADIEUTRI> listss = dbcontext.KHOADIEUTRIs.ToList();
            List<DANTOC> lists = dbcontext.DANTOCs.ToList();
            List<PHONGKHAM> lis = dbcontext.PHONGKHAMs.ToList();
            listView1.Items.Clear();
            foreach (var item in list)
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

        private void bttThem_Click(object sender, EventArgs e)
        {
            Edit = false;
            themmoi = true;
            setNull();
            setButton(false);
            setKhoa(false);
            txtmabs.Focus();
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn muốn xoa", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl == DialogResult.OK)
            {
                if (listView1.Items.Count > 0)
                {
                    string MABS = listView1.SelectedItems[0].SubItems[0].Text;
                    BACSY bs = dbcontext.BACSies.FirstOrDefault(s => s.MABS == MABS);

                    //MessageBox.Show(MABN);
                    dbcontext.BACSies.Remove(bs);
                    dbcontext.SaveChanges();
                    render(dbcontext.BACSies.ToList());
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
            txtmabs.ReadOnly = true;
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (KTnhap()==false)
            {
                if (Edit&&themmoi==false)
                {
                    BACSY bs = dbcontext.BACSies.FirstOrDefault(s => s.MABS == txtmabs.Text);
                    bs.TENBS = txttenbs.Text;
                    string GT = "Nam";
                    if (radiobtnu.Checked)
                    {
                        GT = "Nữ";

                    }
                    bs.GIOITINH = GT;
                    bs.NGAYSINH = dtngaysinh.Value.Date;
                    bs.SDT = txtdienthoai.Text;
                    bs.MADT = cbbdantoc.SelectedValue.ToString();
                    bs.MAPK = cbbpk.SelectedValue.ToString();
                    bs.MAKHOA = cbbkdt.SelectedValue.ToString();

                }
                else
                {
                    BACSY bs = new BACSY();
                    bs.MABS = txtmabs.Text;
                    bs.TENBS = txttenbs.Text;
                    string GT = "Nam";
                    if (radiobtnu.Checked)
                    {
                        GT = "Nữ";

                    }
                    bs.GIOITINH = GT;
                    bs.NGAYSINH = dtngaysinh.Value.Date;
                    bs.SDT = txtdienthoai.Text;
                    bs.MADT = cbbdantoc.SelectedValue.ToString();
                    bs.MAPK = cbbpk.SelectedValue.ToString();
                    bs.MAKHOA = cbbkdt.SelectedValue.ToString();
                    dbcontext.BACSies.Add(bs);
                }
                dbcontext.SaveChanges();
                render(dbcontext.BACSies.ToList());
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
                txtmabs.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txttenbs.Text = listView1.SelectedItems[0].SubItems[1].Text;
                dtngaysinh.Text = listView1.SelectedItems[0].SubItems[2].Text;

                if (listView1.SelectedItems[0].SubItems[3].Text == "Nam")
                {
                    radiobtnam.Checked = true;
                }
                else
                {
                    radiobtnu.Checked = true;

                }
                
                txtdienthoai.Text = listView1.SelectedItems[0].SubItems[4].Text;
                cbbdantoc.Text = listView1.SelectedItems[0].SubItems[5].Text;
                cbbkdt.Text = listView1.SelectedItems[0].SubItems[6].Text;
                cbbpk.Text = listView1.SelectedItems[0].SubItems[7].Text;
            }
        }
        public bool KTnhap()
        {
            if (txtmabs.Text.Trim() == "" || txttenbs.Text.Trim() == "" || cbbpk.Text.Trim() == "" || txtdienthoai.Text.Trim() == "" || cbbkdt.Text.Trim() == "" || cbbdantoc.Text.Trim() == "" || dtngaysinh.Text.Trim() == "" || radiobtnam.Text.Trim() == "" || radiobtnu.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (txtmabs.Text.Trim().Length != 5)
            {
                MessageBox.Show("Mã Bác Sỹ phải có đúng 5 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            if (txttenbs.Text.Length > 40)
            {
                MessageBox.Show("Tên chỉ nhập được tối đa 40 kí tự!", "Thông báo", MessageBoxButtons.OK);
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

            if (KTTrung(txtmabs.Text,0) == true && themmoi==true)
            {
                MessageBox.Show(" bạn nhập mã đã trùng!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }

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