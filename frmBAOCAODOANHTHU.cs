using Microsoft.Reporting.WinForms;
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
    public partial class frmBAOCAODOANHTHU : Form
    {
        public frmBAOCAODOANHTHU()
        {
            InitializeComponent();
        }
        public List<ClassDoanhthu> Convert(List<HOADONTHANHTOAN> list, List<BENHNHAN> list2)
        {
            List<ClassDoanhthu> result = new List<ClassDoanhthu>();
            //ClassDoanhthu str = new ClassDoanhthu();
            for (int i = 0; i < list.Count; i++)
            {
                ClassDoanhthu str = new ClassDoanhthu();
                str.STT = i + 1;
                str.MABN = list[i].BENHNHAN.MABN;
                str.TENBN = list[i].BENHNHAN.TENBN;
                str.NAMSINH = list[i].BENHNHAN.NGAYSINH.ToString();
                str.GIOITINH = list[i].BENHNHAN.GIOITINH;
                str.SOHD = list[i].MAHD.ToString();
                str.NGAYLAP = DateTime.Parse(list[i].NGAYLAP.ToString());
                str.TONGTIEN =decimal.Parse(list[i].TONGTIEN.ToString());
                result.Add(str);
                
            }
 
     
            return result;
        }

        private void frmBAOCAODOANHTHU_Load(object sender, EventArgs e)
        {
            Model1 dbcontext = new Model1();
            this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            var reportDataSource = new ReportDataSource("DataSet1", Convert(dbcontext.HOADONTHANHTOANs.ToList(), dbcontext.BENHNHANs.ToList()));
            this.reportViewer1.LocalReport.DataSources.Clear(); //clear
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
    }
