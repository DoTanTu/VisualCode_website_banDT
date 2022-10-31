using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QUANLYBANHANG_2050531200324
{
    public partial class MASTER_PAGE_USER : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HocKy1_nam3_chuan\TH_WEB_NC\QuanLyBanHangMoi\QuanLyBanHangMoi\App_Data\DATABASE_QUAN_LY_BAN_HANG.mdf;Integrated Security=True";
            cn.Open();
            String SQL = "select * from tbDANHMUC";
            SqlDataAdapter adp = new SqlDataAdapter(SQL, cn);
            DataTable tbDANHMUC = new DataTable();
            adp.Fill(tbDANHMUC);
            Repeater1.DataSource = tbDANHMUC;
            Repeater1.DataBind();
            cn.Close();
        }
        }
    }