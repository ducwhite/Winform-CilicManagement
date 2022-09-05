using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QUANLYPHONGKHAMTU.Entities;

namespace QUANLYPHONGKHAMTU.Entities
{
    class PhieuNT
    {
        Database db;


        public PhieuNT()
        {
            db = new Database();
        }

        public DataTable LayDS()
        {
            string strSQL = "SELECT MAPNT,MANV,NGAYLAP,TONGTIEN FROM PHIEUNHAPTHUOC";

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable LayDSNV()
        {
            string strSQL = "SELECT MANV FROM NV";

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public void Xoa(string mapnt)
        {
            string sSQL = "DELETE FROM PHIEUNHAPTHUOC WHERE MAPNT='" + mapnt + "'";
            db.ExecuteNonQuery(sSQL);
        }

        public void Them(string mapnt, string maNV, string ngaylap, string tongtien)
        {

            string sSQL = string.Format("INSERT INTO PHIEUNHAPTHUOC VALUES('{0}','{1}','{2}',{3})", mapnt, maNV, ngaylap, tongtien);

            db.ExecuteNonQuery(sSQL);
        }

        public void CapNhat(string mapnt, string maNV, string ngaylap)
        {

            string sSQL = string.Format("UPDATE PHIEUNHAPTHUOC SET MANV = '{0}', NGAYLAP = {1} WHERE MAPNT = '{2}'", maNV, ngaylap,mapnt);

            db.ExecuteNonQuery(sSQL);
        }
    }
}
