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
    class Thuoc
    {
        Database db;


        public Thuoc()
        {
            db = new Database();
        }

        public DataTable LayDSThuoc()
        {
            string strSQL = "SELECT MATHUOC,TEN,SOLUONG,DONGIA,DONVITINH,TENLOAI FROM THUOC T,LOAITHUOC L WHERE T.MALOAI=L.MALOAI ";

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable LayDSLoaiThuoc()
        {
            string strSQL = "SELECT * FROM LOAITHUOC";

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public void XoaThuoc(string mathuoc)
        {
            string sSQL = "DELETE FROM THUOC WHERE MATHUOC='" + mathuoc + "'";
            db.ExecuteNonQuery(sSQL);
        }

        public void ThemThuoc(string mathuoc, string tenthuoc, string sl, string dongia, string dvt, string tenloai)
        {
            string strSQL = "SELECT MALOAI FROM LOAITHUOC WHERE TENLOAI=N'" + tenloai + "'";

            DataTable dt = db.Execute(strSQL);
            string sSQL = string.Format("INSERT INTO THUOC VALUES('{0}',N'{1}',{2},{3},N'{4}','{5}')", mathuoc, tenthuoc, sl, dongia, dvt, dt.Rows[0][0].ToString());

            db.ExecuteNonQuery(sSQL);
        }

        public void CapNhatThuoc(string mathuoc, string tenthuoc, string sl, string dongia, string dvt, string tenloai)
        {
            string strSQL = "SELECT MALOAI FROM LOAITHUOC WHERE TENLOAI=N'" + tenloai + "'";

            DataTable dt = db.Execute(strSQL);

            string sSQL = string.Format("UPDATE THUOC SET TEN = N'{0}', SOLUONG = {1}, DONGIA = {2}, DONVITINH = N'{3}',  MALOAI = '{4}' WHERE MATHUOC = '{5}'", tenthuoc, sl, dongia, dvt, dt.Rows[0][0].ToString(), mathuoc);

            db.ExecuteNonQuery(sSQL);
        }
    }
}
