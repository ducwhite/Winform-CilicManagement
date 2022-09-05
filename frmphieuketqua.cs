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
    public partial class frmphieuketqua : DevExpress.XtraEditors.XtraForm
    {
        bool Edit;
        public bool themmoi = true;
        Model1 dbcontext = new Model1();
        public frmphieuketqua()
        {
            InitializeComponent();
        }

        private void frmphieuketqua_Load(object sender, EventArgs e)
        {
            List<PHIEUKETQUA> list = dbcontext.PHIEUKETQUAs.ToList();
            List<BACSY> listss = dbcontext.BACSies.ToList();
            List<PHIEUKHAMBENH> lists = dbcontext.PHIEUKHAMBENHs.ToList();
            FillDataToComboBox(listss);
            FillDataToComboBox1(lists);
            render(list);
            setNull();
            setKhoa(true);
            setButton(true);
        }
        public void setNull()
        {
            txtMaKQ.Text = "";
            txthuyetap.Text = "";
            txtcannag.Text = "";
            txtchieucao.Text = "";
            txtchuandoan.Text = "";
            txtketluan.Text = "";
            txtmach.Text = "";
            txtnhietdo.Text = "";
            txtnhiptho.Text = "";
            txtnoidung.Text = "";
            txttieusu.Text = "";
            cbbtenbs.Text = "";
            cbbMaPKb.Text = "";
        }

       public void setButton(bool bl)
        {
            bttThem.Enabled = bl;
            bttXoa.Enabled = bl;
            bttSua.Enabled = bl;
            bttThoat.Enabled = bl;
            bttLuu.Enabled = !bl;
            bttHuy.Enabled = !bl;
        }

       public void setKhoa(bool bl)
        {
            txtMaKQ.ReadOnly= bl;
            txthuyetap.ReadOnly = bl;
            txtcannag.ReadOnly = bl;
            txtchieucao.ReadOnly = bl;
            txtchuandoan.ReadOnly = bl;
            txtketluan.ReadOnly= bl;
            txtmach.ReadOnly = bl;
            txtnhietdo.ReadOnly = bl;
            txtnhiptho.ReadOnly = bl;
            txtnoidung.ReadOnly = bl;
            txttieusu.ReadOnly= bl;
            cbbtenbs.Enabled = !bl;
            cbbMaPKb.Enabled = !bl;
        }
        public void FillDataToComboBox(List<BACSY> bACSies)

        {
            cbbtenbs.DataSource = bACSies;
            cbbtenbs.DisplayMember = "TENBS";
            cbbtenbs.ValueMember = "MABS";

        }
        public void FillDataToComboBox1(List<PHIEUKHAMBENH> pHIEUKHAMBENHs)

        {
            cbbMaPKb.DataSource = pHIEUKHAMBENHs;
            cbbMaPKb.DisplayMember = "MAPHIEUKB";
            cbbMaPKb.ValueMember = "MAPHIEUKB";


        }
        public void render(List<PHIEUKETQUA> pHIEUKETQUAs)
        {
            List<PHIEUKETQUA> pkq = dbcontext.PHIEUKETQUAs.ToList();
            lsvPKB.Items.Clear();
            foreach (var item in pkq)
            {
                ListViewItem listItem = new ListViewItem(item.MAPHIEUKQ);
                listItem.SubItems.Add(item.MAPHIEUKB);
                listItem.SubItems.Add(item.BACSY.TENBS);
                listItem.SubItems.Add(item.MACH.ToString());
                listItem.SubItems.Add(item.NHIPTHO.ToString());
                listItem.SubItems.Add(item.HUYETAP.ToString());
                listItem.SubItems.Add(item.NHIETDO.ToString());
                listItem.SubItems.Add(item.CANNANG.ToString());
                listItem.SubItems.Add(item.CHIEUCAO.ToString());
                listItem.SubItems.Add(item.NOIDUNG);
                listItem.SubItems.Add(item.CHUANDOAN);
                listItem.SubItems.Add(item.KETLUAN);
                listItem.SubItems.Add(item.TienSu);
                lsvPKB.Items.Add(listItem);
            }

        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            Edit = false;
            themmoi = true;
            setNull();
            setButton(false);
            setKhoa(false);
            txtMaKQ.Focus();
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn muốn xoa", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl == DialogResult.OK)
            {
                if (lsvPKB.Items.Count > 0)
                {
                    string MAKQ = lsvPKB.SelectedItems[0].SubItems[0].Text;
                    PHIEUKETQUA nv = dbcontext.PHIEUKETQUAs.FirstOrDefault(s => s.MAPHIEUKQ == MAKQ);

                    //MessageBox.Show(MABN);
                    dbcontext.PHIEUKETQUAs.Remove(nv);
                    dbcontext.SaveChanges();
                    render(dbcontext.PHIEUKETQUAs.ToList());
                }
            }
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            Edit = true;
            if (lsvPKB.SelectedItems.Count > 0)
            {

                themmoi = false;
                setButton(false);
                setKhoa(false);
            }
            else
                MessageBox.Show("Mời chọn dòng cần sửa", "Thông báo!", MessageBoxButtons.OK);
            txtMaKQ.ReadOnly = true;
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (KTnhap() == false)
            {
                if (Edit && themmoi == false)
                {
                    PHIEUKETQUA nv = dbcontext.PHIEUKETQUAs.FirstOrDefault(s => s.MAPHIEUKQ == txtMaKQ.Text);
                    nv.MAPHIEUKB = cbbMaPKb.SelectedValue.ToString();
                    nv.MABS = cbbtenbs.SelectedValue.ToString();
                    nv.MACH = Int32.Parse(txtmach.Text);
                    nv.NHIPTHO = Int32.Parse(txtnhiptho.Text);
                    nv.HUYETAP = Int32.Parse(txthuyetap.Text);
                    nv.NHIETDO = Int32.Parse(txtnhietdo.Text);
                    nv.CANNANG = Int32.Parse(txtcannag.Text);
                    nv.CHIEUCAO = Int32.Parse(txtchieucao.Text);
                    nv.NOIDUNG = txtnoidung.Text;
                    nv.CHUANDOAN = txtchuandoan.Text;
                    nv.KETLUAN = txtketluan.Text;
                    nv.TienSu = txttieusu.Text;

                }
                else
                {
                    PHIEUKETQUA nv = new PHIEUKETQUA();
                    nv.MAPHIEUKQ = txtMaKQ.Text;
                    nv.MAPHIEUKB = cbbMaPKb.SelectedValue.ToString();
                    nv.MABS = cbbtenbs.SelectedValue.ToString();
                    nv.MACH = Int32.Parse(txtmach.Text);
                    nv.NHIPTHO = Int32.Parse(txtnhiptho.Text);
                    nv.HUYETAP = Int32.Parse(txthuyetap.Text);
                    nv.NHIETDO = Int32.Parse(txtnhietdo.Text);
                    nv.CANNANG = Int32.Parse(txtcannag.Text);
                    nv.CHIEUCAO = Int32.Parse(txtchieucao.Text);
                    nv.NOIDUNG = txtnoidung.Text;
                    nv.CHUANDOAN = txtchuandoan.Text;
                    nv.KETLUAN = txtketluan.Text;
                    nv.TienSu = txttieusu.Text;
                    dbcontext.PHIEUKETQUAs.Add(nv);
                }
                dbcontext.SaveChanges();
                render(dbcontext.PHIEUKETQUAs.ToList());
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

        private void lsvPKB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvPKB.SelectedItems.Count > 0)

            {
                txtMaKQ.Text = lsvPKB.SelectedItems[0].SubItems[0].Text;
                cbbMaPKb.Text = lsvPKB.SelectedItems[0].SubItems[1].Text;
                cbbtenbs.Text = lsvPKB.SelectedItems[0].SubItems[2].Text;
                txtmach.Text = lsvPKB.SelectedItems[0].SubItems[3].Text;
                txtnhiptho.Text = lsvPKB.SelectedItems[0].SubItems[4].Text;
                txthuyetap.Text = lsvPKB.SelectedItems[0].SubItems[5].Text;
                txtnhietdo.Text = lsvPKB.SelectedItems[0].SubItems[6].Text;
                txtcannag.Text = lsvPKB.SelectedItems[0].SubItems[7].Text;
                txtchieucao.Text = lsvPKB.SelectedItems[0].SubItems[8].Text;
                txtnoidung.Text = lsvPKB.SelectedItems[0].SubItems[9].Text;
                txtchuandoan.Text = lsvPKB.SelectedItems[0].SubItems[10].Text;
                txtketluan.Text = lsvPKB.SelectedItems[0].SubItems[11].Text;
                txttieusu.Text = lsvPKB.SelectedItems[0].SubItems[12].Text;


            }
        }
        public bool KTnhap()
        {
            if (txtMaKQ.Text.Trim() == "" || cbbMaPKb.Text.Trim() == "" || cbbtenbs.Text.Trim() == "" || txtmach.Text.Trim() == "" || txtnhiptho.Text.Trim() == "" || txthuyetap.Text.Trim() == "" || txtnhietdo.Text.Trim() == "" || txtcannag.Text.Trim() == "" || txtchieucao.Text.Trim() == "" || txtchuandoan.Text.Trim() == "" || txtnoidung.Text.Trim() == "" || txtketluan.Text.Trim() == "" )
            {
                MessageBox.Show("Không được để trống!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            if (txtMaKQ.Text.Trim().Length != 6)
            {
                MessageBox.Show("Mã kết quả phải có đúng 6 kí tự!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
           

            if (KTTrung(txtMaKQ.Text, 0) == true && themmoi == true)
            {
                MessageBox.Show(" bạn nhập mã đã trùng!", "Thông báo!", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }

        int idex;
        private bool KTTrung(string str, int index)
        {
            for (int i = 0; i < lsvPKB.Items.Count; i++)
            {
                if (i != idex && themmoi == false)
                {
                    if (lsvPKB.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
                if (themmoi == true)
                {
                    if (lsvPKB.Items[i].SubItems[index].Text == str)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }
        private string LayMABN(string id)
        {
            List<PHIEUKHAMBENH> PHIEUKHAMBENHs = dbcontext.PHIEUKHAMBENHs.ToList<PHIEUKHAMBENH>();
            foreach (PHIEUKHAMBENH bn in PHIEUKHAMBENHs)
            {
                if (bn.MAPHIEUKB == id)
                    return bn.MABN;

            }
            return "";
        }
        private string LayTENBN(string id)
        {
            string id1 = LayMABN(id);
            List<BENHNHAN> BENHNHANs = dbcontext.BENHNHANs.ToList<BENHNHAN>();
            foreach (BENHNHAN bn in BENHNHANs)
            {
                if (bn.MABN == id1)
                    return bn.TENBN;

            }
            return "";
        }

        private void cbbMaPKb_SelectedIndexChanged(object sender, EventArgs e)
        {
            textEdit1.Text = LayTENBN(cbbMaPKb.SelectedValue.ToString());
            
        }

        private void txtmach_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void mach_Click(object sender, EventArgs e)
        {

        }
    }
    }