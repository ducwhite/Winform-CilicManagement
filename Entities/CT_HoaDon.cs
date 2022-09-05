using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QUANLYPHONGKHAMTU.Entities;

namespace Quanlyphongkham.Entities
{
    class CT_HoaDon
    {
        Database db;


        public CT_HoaDon()
        {
            db = new Database();
        }

        public DataTable LayDS()
        {
            string strSQL = "SELECT * FROM CT_HOADON";

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable LayDSPhieuKQ(string matt)
        {
            string strSQL = string.Format("SELECT MAPHIEUKQ,MAPHIEUKB FROM TOATHUOC WHERE MATOATHUOC = '{0}'", matt);

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable LayDSHD()
        {
            string strSQL = string.Format("SELECT MAHD FROM HOADONTHANHTOAN HD");

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable LayDSToa(string mahd)
        {
            string strSQL = string.Format("SELECT T.MATOATHUOC FROM TOATHUOC T,HOADONTHANHTOAN HD, PHIEUKHAMBENH P WHERE HD.MAHD = '{0}' AND P.MABN=HD.MABN AND T.MAPHIEUKB=P.MAPHIEUKB", mahd);

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable LayDSToa()
        {
            string strSQL = string.Format("SELECT MATOATHUOC FROM TOATHUOC");

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable LayDSPhieuCLS()
        {
            string strSQL = string.Format("SELECT MAPCLS FROM PHIEUCANLAMSANG");

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable LayDSPhieuCLS(string mahd)
        {
            string strSQL = string.Format("SELECT P.MAPCLS FROM PHIEUCANLAMSANG P,HOADONTHANHTOAN HD WHERE HD.MAHD = '{0}' AND P.MABN = HD.MABN", mahd);

            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public void Xoa(string mahd, string matoa)
        {
            string sSQL = string.Format("DELETE FROM CT_HOADON WHERE MAHD='{0}' AND MATOATHUOC ='{1}'", mahd,matoa);
            db.ExecuteNonQuery(sSQL);
        }

        public void Them(string mahd, string matoa,string mapcls, string mapkq, string mapkb)
        {

            string sSQL = string.Format("INSERT INTO CT_HOADON VALUES('{0}','{1}','{2}','{3}','{4}')", mahd,matoa,mapcls,mapkq,mapkb);

            db.ExecuteNonQuery(sSQL);
        }

        public void CapNhat(string mahd, string matoa, string mapcls, string mapkq, string mapkb, string matoacu)
        {

            string sSQL = string.Format("UPDATE CT_HOADON SET MATOATHUOC = '{0}', MAPCLS = '{1}', MAPHIEUKQ = '{2}', MAPHIEUKB = '{3}' WHERE MAHD = '{4}' AND MATHUOC = '{5}'", matoa,mapcls,mapkq,mapkb,mahd,matoacu);

            db.ExecuteNonQuery(sSQL);
        }

        public void TinhTien(string mapnt)
        {
            string sSQL = string.Format("UPDATE HOADONTHANHTOAN SET TONGTIEN = (SELECT SUM(P.TONGTIEN + T.TONGTIEN + LK.GIA) FROM HOADONTHANHTOAN HD, CT_HOADON CT,PHIEUCANLAMSANG P,TOATHUOC T,PHIEUKHAMBENH PKB,LOAIKHAM LK WHERE HD.MAHD = '{0}'  AND HD.MAHD=CT.MAHD AND CT.MAPCLS=P.MAPCLS AND CT.MATOATHUOC=T.MATOATHUOC AND CT.MAPHIEUKB=PKB.MAPHIEUKB AND PKB.MALOAIK=LK.MALOAIK ) WHERE MAHD = '{0}'", mapnt);
            db.ExecuteNonQuery(sSQL);
        }
    }
}
