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
    class CT_PNT
    {
        Database db;


        public CT_PNT()
        {
            db = new Database();
        }

        public DataTable LayDS()
        {
            string strSQL = "SELECT MAPNT,TEN,TENNCC,CT.SOLUONG,CT.DONGIA,CT.DONVITINH FROM CT_PHIEUNHAPTHUOC CT,THUOC T,NCC N WHERE CT.MANCC = N.MANCC AND CT.MATHUOC = T.MATHUOC";

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable LayDSPhieu()
        {
            string strSQL = "SELECT MAPNT FROM PHIEUNHAPTHUOC";

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable LayDSThuoc()
        {
            string strSQL = "SELECT * FROM THUOC";

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable LayDSNCC()
        {
            string strSQL = "SELECT * FROM NCC";

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable TimNCC(string mathuoc)
        {
            string strSQL = "SELECT N.MANCC,TENNCC FROM NCC N,THUOC T,CT_CUNGCAPTHUOC CT WHERE T.MATHUOC='" + mathuoc + "' AND CT.MATHUOC = T.MATHUOC AND CT.MANCC=N.MANCC";

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public void Xoa(string mapnt, string mathuoc,string mancc, string sl)
        {
            string sSQL = string.Format("DELETE FROM CT_PHIEUNHAPTHUOC WHERE MAPNT='{0}' AND MATHUOC ='{1}' AND MANCC='{2}'",mapnt,mathuoc,mancc);
            db.ExecuteNonQuery(sSQL);

            string SQL = string.Format("UPDATE THUOC SET SOLUONG = (SOLUONG - {0}) WHERE MATHUOC = '{1}'", sl, mathuoc);

            db.ExecuteNonQuery(SQL);
        }

        public void Them(string mapnt, string mathuoc, string mancc, string sl, string dongia, string dvt)
        {

            string sSQL = string.Format("INSERT INTO CT_PHIEUNHAPTHUOC VALUES('{0}','{1}','{2}',{3},{4},N'{5}' )", mapnt, mathuoc, mancc, sl, dongia, dvt);

            db.ExecuteNonQuery(sSQL);

            string SQL = string.Format("UPDATE THUOC SET SOLUONG = (SOLUONG + {0}) WHERE MATHUOC = '{1}'", sl, mathuoc);

            db.ExecuteNonQuery(SQL);
        }

        public void CapNhat(string mapnt, string mathuoc, string mancc, string sl, string dongia, string dvt, string slcu)
        {

            string sSQL = string.Format("UPDATE CT_PHIEUNHAPTHUOC SET SOLUONG = {0}, DONGIA = {1}, DONVITINH = N'{2}' WHERE MAPNT = '{3}' AND MATHUOC = '{4}' AND MANCC='{5}'", sl, dongia, dvt, mapnt,mathuoc,mancc);

            db.ExecuteNonQuery(sSQL);

            string SQL = string.Format("UPDATE THUOC SET SOLUONG = (SOLUONG - {0} + {1}) WHERE MATHUOC = '{2}'", slcu, sl, mathuoc);

            db.ExecuteNonQuery(SQL);
        }

        public void TinhTien(string mapnt)
        {
            string sSQL = string.Format("UPDATE PHIEUNHAPTHUOC SET TONGTIEN = (SELECT TONGTIEN = SUM(CT.SOLUONG * CT.DONGIA) FROM PHIEUNHAPTHUOC P, CT_PHIEUNHAPTHUOC CT WHERE P.MAPNT = CT.MAPNT AND P.MAPNT = '{0}') WHERE MAPNT = '{0}'",mapnt);
            db.ExecuteNonQuery(sSQL);
        }
    }
}
