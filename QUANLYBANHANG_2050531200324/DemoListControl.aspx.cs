using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QUANLYBANHANG_2050531200324
{
    public partial class DemoListControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                ListItem item = new ListItem();
                item.Text = i.ToString();
                item.Value = i.ToString();
                ListBox1.Items.Add(item);
                DropDownList1.Items.Add(item);
                CheckBoxList1.Items.Add(item);
                RadioButtonList1.Items.Add(item);
            }    
       
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write(ListBox1.SelectedItem);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int indexitem = ListBox1.SelectedIndex;
            ListBox1.Items.RemoveAt(indexitem);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
        }
    }
}