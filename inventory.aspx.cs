using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace WebApplication7
{
    public partial class inventory : System.Web.UI.Page
    {
        public string mystring = "Data Source=DESKTOP-9HUANL2\\KHEHRA05;Initial Catalog=newP;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "select brand as 'Brand Name', availableQuantity as 'Number of Products' from productList";
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
            string query2 = "select  brand as 'Brand Name', productName as 'Product Name' , availableQuantity as 'Available Quantity'from productList ";
            SqlConnection con1 = new SqlConnection(mystring);
            SqlCommand cmd1 = new SqlCommand();
            cmd.CommandText = query2;
            cmd.Connection = con1;
            SqlDataAdapter da1 = new SqlDataAdapter();
            da1.SelectCommand = cmd;
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            GridView2.DataSource = ds1;
            GridView2.DataBind();
            con1.Close();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {






        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/addBrand.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/addProduct.aspx");
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
            Response.Redirect("~/login.aspx");
        }
    }
}