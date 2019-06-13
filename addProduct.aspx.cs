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
    public partial class addProduct : System.Web.UI.Page
    {
        public string mystring = "Data Source=desktop-9huanl2\\khehra05;Initial Catalog=newP;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "select * from productList";
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
            SqlConnection con = new SqlConnection(mystring);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
              cmd.CommandText = " insert into productList values('" + TextBox2.Text + "','" + TextBox6.Text + "','"+TextBox5.Text+"')";

            cmd.ExecuteNonQuery();
            con.Close();
            TextBox6.Text = "";
            TextBox2.Text = "";

            string query = "select * from productList";
            SqlConnection con1 = new SqlConnection(mystring);
            SqlCommand cmd1 = new SqlCommand(query, con1);
            cmd.CommandText = query;
            cmd.Connection = con1;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con1.Close();
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}