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
        public string mystring = "Data Source=desktop-6ddcjgt;Initial Catalog=sunglassonline;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
           /* if (!Page.IsPostBack)
            {
                DropDownList2.DataSource = DropDownList2.SelectedItem.Value;
                DropDownList2.DataBind();
            }*/
                string query = "select * from productListt";
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
              cmd.CommandText = " insert into productListt values('"+ DropDownList2.SelectedValue +"','" + TextBox2.Text + "','" + TextBox6.Text + 
                "','"+TextBox5.Text+ "','" + DropDownList1.SelectedValue + "')";

            cmd.Parameters.AddWithValue("brand", DropDownList2.SelectedItem.Value);
            
            TextBox6.Text = "";
            TextBox2.Text = "";
            TextBox5.Text = "";
            cmd.Parameters.AddWithValue("availableQuantity", DropDownList1.SelectedItem.Value);
             cmd.ExecuteNonQuery();
            con.Close();

            string query = "select * from productListt";
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