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
    public partial class brandEdit1 : System.Web.UI.Page
    {
        public string mystring = "Data Source=DESKTOP-9HUANL2\\KHEHRA05;Initial Catalog=newP;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                bindData();
        }

        private void bindData()
        {
            string query = "select * from [brandList]";
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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            Response.Redirect("~/Brands List.aspx");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(mystring);
            con.Open();

            string a = "update [brandList] set brandID= '" + TextBox1.Text.ToString()
                + "', brandName = '" + TextBox2.Text.ToString()
                + "' WHERE brandID='" + HiddenField1.Value.ToString() + "';";
            SqlCommand cmd = new SqlCommand(a, con);
            cmd.ExecuteNonQuery();
            bindData();
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/inventory.aspx");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Brands List.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/productList.aspx");
        }

        protected void GridView1_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Deletee")
            {
                int rowID = Convert.ToInt32(e.CommandArgument);
                TextBox1.Text = GridView1.Rows[rowID].Cells[0].Text;
                TextBox2.Text = GridView1.Rows[rowID].Cells[1].Text;

                SqlConnection con = new SqlConnection(mystring);
                con.Open();
                string delete = "delete from [brandList] where brandID = '" + TextBox1.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                Response.Write("deleted successfully");
                bindData();
            }

            if (e.CommandName == "Editt")
            {
                int rowID = Convert.ToInt32(e.CommandArgument);
                TextBox1.Text = GridView1.Rows[rowID].Cells[0].Text;
                TextBox2.Text = GridView1.Rows[rowID].Cells[1].Text;
                HiddenField1.Value = TextBox1.Text;
            }
        }

       
    }
    }