using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QUANLYBANHANG_2050531200324
{
    public partial class pageCHITIET : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            XULYDULIEU xULYDULIEU = new XULYDULIEU();
            String masp = Request.QueryString.Get("MSP");
            SqlParameter[] pr;
            if (masp != null)
                pr = new SqlParameter[] { new SqlParameter("@MaSanPham", masp) };
            else
                pr = new SqlParameter[] { new SqlParameter("@MaSanPham", DBNull.Value) };
            DataTable tbSANPHAM = xULYDULIEU.GetTable("psGetCHITIETSANPHAM", pr);
            Repeater2.DataSource = tbSANPHAM;
            Repeater2.DataBind();
            int soLuong = Convert.ToInt32(tbSANPHAM.Rows[0]["SOLUONG"].ToString());
            for(int i = 0; i <= soLuong; i++)
            {
                this.drlSOLUONG.Items.Add(i.ToString());
            }
        }
    }
}