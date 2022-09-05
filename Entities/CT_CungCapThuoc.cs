using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QUANLYPHONGKHAMTU.Entities;

namespace QUANLYPHONGKHAMTU
{
    class CT_CungCapThuoc
    {
        Database db;


        public CT_CungCapThuoc()
        {
            db = new Database();
        }

        public DataTable LayDS()
        {
            string strSQL = "SELECT TENNCC,TEN FROM THUOC T,NCC N,CT_CungCapThuoc CT WHERE CT.MATHUOC = T.MATHUOC AND CT.MANCC=N.MANCC";

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable LayDSThuoc()
        {
            string strSQL = "SELECT MATHUOC,TEN FROM THUOC";

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable LayDSNCC()
        {
            string strSQL = "SELECT MANCC,TENNCC FROM NCC";

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public void Xoa(string mathuoc, string mancc)
        {
            string sSQL = string.Format("DELETE FROM CT_CungCapThuoc WHERE MANCC='{0}' AND MATHUOC ='{1}'", mancc, mathuoc);
            db.ExecuteNonQuery(sSQL);
        }

        public void Them(string mathuoc, string mancc)
        {

            string sSQL = string.Format("INSERT INTO CT_CungCapThuoc VALUES('{0}','{1}')", mathuoc, mancc);

            db.ExecuteNonQuery(sSQL);
        }

        public void CapNhat(string mathuoc, string mancc, string mathuoccu)
        {

            string sSQL = string.Format("UPDATE CT_CungCapThuoc SET MATHUOC = '{0}' WHERE MANCC = '{1}' AND MATHUOC = '{2}'", mathuoc, mancc, mathuoccu);

            db.ExecuteNonQuery(sSQL);
        }
    }
}
