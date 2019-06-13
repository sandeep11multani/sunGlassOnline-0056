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
    public partial class editbrand : System.Web.UI.Page
    {
        public string mystring = "Data Source=desktop-9huanl2\\khehra05;Initial Catalog=newP;Integrated Security=True";
        public int id;
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
            GridView2.DataSource = ds;
            GridView2.DataBind();
            con.Close();
            if (con.State==ConnectionState.Open)
            {
                con.Close();

            }
            con.Open();
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from brandList";
            cmd1.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt);
            GridView2.DataSource = dt;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(mystring);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from brandList";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da1.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                TextBox1.Text = dr["brandID "].ToString();
                TextBox2.Text = dr["brandName"].ToString();
            }
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/inventory.aspx");
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

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