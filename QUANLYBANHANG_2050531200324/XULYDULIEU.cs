using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace QUANLYBANHANG_2050531200324
{
    public class XULYDULIEU
    {
        SqlConnection con;
        public XULYDULIEU()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HocKy1_nam3_chuan\TH_WEB_NC\QUANLYBANHANG_2050531200324\QUANLYBANHANG_2050531200324\App_Data\DATABASE_QUAN_LY_BAN_HANG.mdf;Integrated Security=True";
        }

        private void MoKetNoi()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

        }
        private void DongKetNoi()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public DataTable GetTable(String sql)
        {
            MoKetNoi();
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            DongKetNoi();
            return dt;
        }

        public DataTable GetTable(String nameProcedure, SqlParameter[] pr)
        {
            MoKetNoi();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nameProcedure;
            if (pr != null)
            {
                cmd.Parameters.AddRange(pr);
            }
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(tb);
            DongKetNoi();
            return tb;
        }
        public void getDataSet(ref DataSet ds, String SQL)
        {
            ds.Tables.Add(this.GetTable(SQL));
        }

        public void GetDataSet(ref DataSet ds, String nameprocedure, SqlParameter[] pr)
        {

            ds.Tables.Add(this.GetTable(nameprocedure, pr));

        }
        public int ExeCute(String SQL)
        {
            this.MoKetNoi();
            SqlCommand cmd = new SqlCommand(SQL, this.con);
            this.DongKetNoi();
            int k = (int)cmd.ExecuteNonQuery();
            return k;

        }

        public int ExeCute(String nameprocedure, SqlParameter[] pr)
        {
            this.MoKetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nameprocedure;
            if (pr == null)
                cmd.Parameters.AddRange(pr);
            this.DongKetNoi();
            int k = (int)cmd.ExecuteNonQuery();
            return k;
        }
    }
}