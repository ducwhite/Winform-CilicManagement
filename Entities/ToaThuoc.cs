using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QUANLYPHONGKHAMTU.Entities
{
    class ToaThuoc
    {
        Database db;


        public ToaThuoc()
        {
            db = new Database();
        }

        public DataTable LayDS()
        {
            string strSQL = "SELECT * FROM TOATHUOC";

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable LayDSPhieuKQ()
        {
            string strSQL = "SELECT MAPHIEUKQ,MAPHIEUKB FROM PHIEUKETQUA";

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public void Xoa(string matt)
        {
            string sSQL = "DELETE FROM TOATHUOC WHERE MATOATHUOC='" + matt + "'";
            db.ExecuteNonQuery(sSQL);
        }

        public void Them(string matt, string mapkq, string mapkb,string ngaylap, string tongtien)
        {

            string sSQL = string.Format("INSERT INTO TOATHUOC VALUES('{0}','{1}','{2}','{3}',{4})", matt, mapkq,mapkb, ngaylap, tongtien);

            db.ExecuteNonQuery(sSQL);
        }

        public void CapNhat(string matt, string ngaylap)
        {

            string sSQL = string.Format("UPDATE TOATHUOC SET NGAYLAP = '{0}' WHERE MATOATHUOC = '{1}'", ngaylap, matt);

            db.ExecuteNonQuery(sSQL);
        }
    }
}
