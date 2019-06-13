using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication7
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Visible = false;
            
        }
        public string mystring = "Data Source=desktop-9huanl2\\khehra05;Initial Catalog=newP;Integrated Security=True";

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(mystring);
            con.Open();
            string query = "select COUNT(1) from signup where username=@username  and password=@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", TextBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@password", TextBox2.Text.Trim());
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count==1)
            {
                Session["username"] = TextBox1.Text.Trim();
                Response.Redirect("~/inventory.aspx");
            }
            else
            {
                Label2.Visible = true;
            }

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}