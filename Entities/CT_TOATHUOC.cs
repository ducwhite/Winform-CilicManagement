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
    class CT_TOATHUOC
    {
        Database db;


        public CT_TOATHUOC()
        {
            db = new Database();
        }

        public DataTable LayDS()
        {
            string strSQL = "SELECT MATOATHUOC,MAPHIEUKQ,MAPHIEUKB,TEN,CT.SOLUONG FROM CT_TOATHUOC CT,THUOC T WHERE CT.MATHUOC = T.MATHUOC";

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable LayDSToa()
        {
            string strSQL = string.Format("SELECT MATOATHUOC FROM TOATHUOC");

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable LayDSPhieuKQ(string matt)
        {
            string strSQL = string.Format("SELECT MAPHIEUKQ,MAPHIEUKB FROM TOATHUOC WHERE MATOATHUOC = '{0}'",matt);

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public int LayDSSLTHUOC(string mathuoc)
        {
            string strSQL = string.Format("SELECT SOLUONG FROM THUOC WHERE MATHUOC = '{0}'", mathuoc);

            DataTable dt = db.Execute(strSQL);
            return int.Parse(dt.Rows[0][0].ToString());
        }

        public int LayDSSLTHUOC_EDIT(string mathuoc, string sl)
        {
            string strSQL = string.Format("SELECT SOLUONG = (SOLUONG + {0}) FROM THUOC WHERE MATHUOC = '{1}'",sl, mathuoc);

            DataTable dt = db.Execute(strSQL);
            return int.Parse(dt.Rows[0][0].ToString());
        }

        public DataTable LayDSThuoc()
        {
            string strSQL = "SELECT MATHUOC,TEN FROM THUOC";

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public void Xoa(string matt, string mathuoc, string sl)
        {
            string sSQL = string.Format("DELETE FROM CT_TOATHUOC WHERE MATOATHUOC='{0}' AND MATHUOC ='{1}'", matt, mathuoc);
            db.ExecuteNonQuery(sSQL);

            string SQL = string.Format("UPDATE THUOC SET SOLUONG = (SOLUONG + {0}) WHERE MATHUOC = '{1}'", sl, mathuoc);

            db.ExecuteNonQuery(SQL);
        }

        public void Them(string matt,string mapkq, string mapkb, string mathuoc, string sl)
        {

            string sSQL = string.Format("INSERT INTO CT_TOATHUOC VALUES('{0}','{1}','{2}','{3}',{4})", matt,mapkq,mapkb, mathuoc, sl);

            db.ExecuteNonQuery(sSQL);

            string SQL = string.Format("UPDATE THUOC SET SOLUONG = (SOLUONG - {0}) WHERE MATHUOC = '{1}'", sl, mathuoc);

            db.ExecuteNonQuery(SQL);
        }

        public void CapNhat(string matt,string mathuoc, string sl, string slcu)
        {

            string sSQL = string.Format("UPDATE CT_TOATHUOC SET SOLUONG = {0} WHERE MATOATHUOC = '{1}' AND MATHUOC = '{2}'", sl, matt, mathuoc);

            db.ExecuteNonQuery(sSQL);

            string SQL = string.Format("UPDATE THUOC SET SOLUONG = (SOLUONG + {0} - {1}) WHERE MATHUOC = '{2}'", slcu, sl, mathuoc);

            db.ExecuteNonQuery(SQL);
        }

        public void TinhTien(string matt)
        {
            string sSQL = string.Format("UPDATE TOATHUOC SET TONGTIEN = (SELECT TONGTIEN=SUM(CT.SOLUONG*T.DONGIA) FROM TOATHUOC TT, CT_TOATHUOC CT,THUOC T WHERE TT.MATOATHUOC=CT.MATOATHUOC AND CT.MATHUOC = T.MATHUOC AND TT.MATOATHUOC = '{0}') WHERE MATOATHUOC = '{0}'", matt);
            db.ExecuteNonQuery(sSQL);
        }
    }
}
