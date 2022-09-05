using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QUANLYPHONGKHAMTU.Entities;
namespace Quanlyphongkham.Entities
{
    class PhongCho
    {
        Database db;


        public PhongCho()
        {
            db = new Database();
        }

        public DataTable LayDSPK()
        {
            string strSQL = "SELECT * FROM PHONGKHAM";

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable LayDSPhieuKB(string mapk, int index, string ngaylap)
        {
            string strSQL = "";
            if (index == 0) // tất cả
            {
                strSQL = string.Format("SELECT MAPHIEUKB,TENBN,TEN,TINHTRANG FROM PHIEUKHAMBENH PK,BENHNHAN BN,LOAIKHAM LK WHERE PK.MAPK = '{0}' AND NGAYLAP = '{1}' AND PK.MABN=BN.MABN AND PK.MALOAIK=LK.MALOAIK ", mapk, ngaylap);
            }
            if (index == 1) // chưa khám
            {
                strSQL = string.Format("SELECT MAPHIEUKB,TENBN,TEN,TINHTRANG FROM PHIEUKHAMBENH PK,BENHNHAN BN,LOAIKHAM LK WHERE PK.MAPK = '{0}' AND NGAYLAP = '{1}' AND TINHTRANG = {2} AND PK.MABN=BN.MABN AND PK.MALOAIK=LK.MALOAIK ", mapk, ngaylap, 0);
            }
            if (index == 2) // đã khám
            {
                strSQL = string.Format("SELECT MAPHIEUKB,TENBN,TEN,TINHTRANG FROM PHIEUKHAMBENH PK,BENHNHAN BN,LOAIKHAM LK WHERE PK.MAPK = '{0}' AND NGAYLAP = '{1}' AND TINHTRANG = {2} AND PK.MABN=BN.MABN AND PK.MALOAIK=LK.MALOAIK ", mapk, ngaylap, 1);
            }
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
    }
}
