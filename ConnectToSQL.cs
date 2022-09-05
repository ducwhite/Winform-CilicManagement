using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Quanlyphongkham
{
    class ConnectToSQL
    {
        #region Availible
        private SqlConnection Conn;
        private SqlCommand cmd = new SqlCommand();
        private string StrCon = null;
        #endregion
        #region Contrustor
        public ConnectToSQL()
        {
            StrCon = @"Data Source=DESKTOP-1A68DCF;Initial Catalog=QUANLYPHONGKHAM;Integrated Security=True";
            Conn = new SqlConnection(StrCon);
        }
        #endregion

        #region Methods
        public bool OpenConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool CloseConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Open)
                    Conn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conn;
            try
            {
                this.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                this.CloseConn();
            }
            return dt;
        }

        public bool SetData(string sql)
        {
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conn;
            try
            {
                this.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                this.CloseConn();
            }
            return false;
        }
        #endregion
    }
}