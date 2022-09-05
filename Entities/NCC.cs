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
    class NCC
    {
        Database db;
        

        public NCC()
        {
            db = new Database();
        }

        public DataTable LayDSNCC()
        {
            string strSQL = "SELECT * FROM NCC ";

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public void XoaNCC(string mancc)
        {
            string sSQL = "DELETE FROM NCC WHERE MANCC='" + mancc + "'";
            db.ExecuteNonQuery(sSQL);
        }

        public void ThemNCC(string mancc,string tenncc,string sdt, string diachi, string email, string website)
        {
            string sSQL = string.Format("INSERT INTO NCC VALUES('{0}',N'{1}','{2}',N'{3}','{4}','{5}')", mancc,tenncc,sdt,diachi,email,website);

            db.ExecuteNonQuery(sSQL);
        }

        public void CapNhatNCC(string mancc, string tenncc, string sdt, string diachi, string email, string website)
        {
            string sSQL = string.Format("UPDATE NCC SET TENNCC = N'{0}', SDT = '{1}', DIACHI = N'{2}', EMAIL = '{3}',  WEBSITE = '{4}' WHERE MANCC = {5}",tenncc,sdt,diachi,email,website,mancc);

            db.ExecuteNonQuery(sSQL);
        }
    }
}
