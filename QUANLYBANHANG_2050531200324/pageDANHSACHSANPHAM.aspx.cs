using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace QUANLYBANHANG_2050531200324
{
   
    public partial class pageDANHSACHSANPHAM : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
            XULYDULIEU xULYDULIEU = new XULYDULIEU();
            String madm = Request.QueryString.Get("MADANHMUC");
            SqlParameter[] pr;
            if (madm != null)
                pr = new SqlParameter[] { new SqlParameter("@MaDanhMuc", madm) };
            else
                pr = new SqlParameter[] { new SqlParameter("@MaDanhMuc", DBNull.Value) };
            DataList1.DataSource = xULYDULIEU.GetTable("psGetSANPHAM",pr);
            DataList1.DataBind();
            DataList1.RepeatColumns = 4;
        }
    }
}