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
    public partial class frmctsddv : DevExpress.XtraEditors.XtraForm
    {
        bool Edit;
        public bool themmoi = false;
        Model1 dbcontext = new Model1();
        public frmctsddv()
        {
            InitializeComponent();
        }

        private void frmctsddv_Load(object sender, EventArgs e)
        {
            List<CT_SDDV> list1 = dbcontext.CT_SDDV.ToList();
            List<PHIEUCANLAMSANG> list2 = dbcontext.PHIEUCANLAMSANGs.ToList();
            List<DICHVU> list3 = dbcontext.DICHVUs.ToList();
            FillDataToComboBox2(list2);
            FillDataToComboBox3(list3);
            render(list1);
            setNull();
            setButton(true);
            setKhoa(true);
        }
        public void setNull()
        {
            cbbmadv.Text = "";
            cbbmapcls.Text = "";
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
            cbbmadv.Enabled = !bl;
            cbbmapcls.Enabled = !bl;
        }
        public void FillDataToComboBox2(List<PHIEUCANLAMSANG> pHIEUCANLAMSANGs)
        {
            cbbmapcls.DataSource = pHIEUCANLAMSANGs;
            cbbmapcls.DisplayMember = "TENPK";
            cbbmapcls.ValueMember = "MAPCLS";
        }
        public void FillDataToComboBox3(List<DICHVU> dICHVUs)
        {
            cbbmadv.DataSource = dICHVUs;
            cbbmadv.DisplayMember = "TENDV";
            cbbmadv.ValueMember = "MADV";
        }
        public void render(List<CT_SDDV> cT_SDDVs)
        {
            List<CT_SDDV> list1 = dbcontext.CT_SDDV.ToList();
            List<PHIEUCANLAMSANG> list2 = dbcontext.PHIEUCANLAMSANGs.ToList();
            List<DICHVU> list3 = dbcontext.DICHVUs.ToList();
            lsvctsddv.Items.Clear();
            foreach (var item in list1)
            {
                ListViewItem listItem = new ListViewItem(item.MAPCLS);
                listItem.SubItems.Add(item.DICHVU.TENDV);
                lsvctsddv.Items.Add(listItem);
            }
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            Edit = false;
            themmoi = true;
            setNull();
            setButton(false);
            setKhoa(false);
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn muốn xoa", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl == DialogResult.OK)
            {
                if (lsvctsddv.Items.Count > 0)
                {
                    string MAPCLS = lsvctsddv.SelectedItems[0].SubItems[0].Text;
                    CT_SDDV ct = dbcontext.CT_SDDV.FirstOrDefault(s => s.MAPCLS == MAPCLS);

                    //MessageBox.Show(MABN);
                    dbcontext.CT_SDDV.Remove(ct);
                    dbcontext.SaveChanges();
                    render(dbcontext.CT_SDDV.ToList());
                }
            }
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            Edit = true;
            if (lsvctsddv.SelectedItems.Count > 0)
            {

                themmoi = false;
                setButton(false);
                setKhoa(false);
            }
            else
                MessageBox.Show("Mời chọn dòng cần sửa", "Thông báo!", MessageBoxButtons.OK);
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (KTnhap()==false)
            {
                if (Edit && themmoi == false)
                {
                    CT_SDDV bs = dbcontext.CT_SDDV.FirstOrDefault(s => s.MAPCLS == cbbmapcls.SelectedValue.ToString());
                    bs.MADV = cbbmadv.SelectedValue.ToString();
                }
                else
                {
                    CT_SDDV bs = new CT_SDDV();
                    bs.MAPCLS = cbbmapcls.SelectedValue.ToString();
                    bs.MADV = cbbmadv.SelectedValue.ToString();
                    dbcontext.CT_SDDV.Add(bs);
                }
                dbcontext.SaveChanges();
                render(dbcontext.CT_SDDV.ToList());
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
            if (lsvctsddv.SelectedItems.Count > 0)

            {

                cbbmapcls.Text = lsvctsddv.SelectedItems[0].SubItems[0].Text;
                cbbmadv.Text = lsvctsddv.SelectedItems[0].SubItems[1].Text;


            }
        }

        private void cbbmapcls_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public bool KTnhap()
        {
            if (KTTrung(cbbmapcls.Text, 0) == true && themmoi == true)
            {
                MessageBox.Show("Mã bạn nhập đã trùng!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }
        int idex;
        private bool KTTrung(string str, int index)
        {
            for (int i = 0; i < lsvctsddv.Items.Count; i++)
            {
                if (i != idex && themmoi == false)
                {
                    if (lsvctsddv.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
                if (themmoi == true)
                {
                    if (lsvctsddv.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}