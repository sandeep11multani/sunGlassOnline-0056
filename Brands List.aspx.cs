using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Sunglasses_Online
{
    public partial class Brands_List : System.Web.UI.Page
    {
        public string mystring = "Data Source=desktop-9huanl2\\khehra05;Initial Catalog=newP;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "select * from brandList";
            SqlConnection con = new SqlConnection(mystring);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/addBrand.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/inventory.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Brands List.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/productList.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm2.aspx");
        }
    }
}