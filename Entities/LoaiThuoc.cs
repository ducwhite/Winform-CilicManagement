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
    class LoaiThuoc
    {
        Database db;


        public LoaiThuoc()
        {
            db = new Database();
        }

        public DataTable LayDSLoaiThuoc()
        {
            string strSQL = "SELECT * FROM LOAITHUOC";

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public void XoaLoaiThuoc(string malt)
        {
            string sSQL = "DELETE FROM LOAITHUOC WHERE MALOAI='" + malt + "'";
            db.ExecuteNonQuery(sSQL);
        }

        public void ThemLoaiThuoc(string malt, string tenlt)
        {
            string sSQL = string.Format("INSERT INTO LOAITHUOC VALUES('{0}',N'{1}')", malt,tenlt);

            db.ExecuteNonQuery(sSQL);
        }

        public void CapNhatLoaiThuoc(string malt, string tenlt)
        {

            string sSQL = string.Format("UPDATE LOAITHUOC SET TENLOAI = N'{0}' WHERE MALOAI = '{1}'", tenlt,malt);

            db.ExecuteNonQuery(sSQL);
        }
    }
}
