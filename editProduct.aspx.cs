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
    public partial class editProduct : System.Web.UI.Page
    {
        public string mystring = "Data Source=DESKTOP-9HUANL2\\KHEHRA05;Initial Catalog=newP;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                binddata();
        }
        private void binddata()
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

            string a = "update [productList] set productID= '" + TextBox2.Text.ToString()
                + "', brand = '" + DropDownList2.Text.ToString() 
                +"', productName= '"+ TextBox6.Text.ToString()
                +"', salesPrice= '" + TextBox5.Text.ToString()
                +"', availableQuantity= '" +DropDownList1.Text.ToString()
                +"' WHERE productID= '" + HiddenField1.Value.ToString() + "';";
            SqlCommand cmd = new SqlCommand(a, con);
            cmd.ExecuteNonQuery();
            binddata();
            TextBox5.Text = "";
            TextBox2.Text = "";
            TextBox6.Text = "";
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
           
        }

        protected void GridView1_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Deletee")
            {
                int rowID = Convert.ToInt32(e.CommandArgument);
                DropDownList1.Text = GridView1.Rows[rowID].Cells[4].Text;
                TextBox5.Text = GridView1.Rows[rowID].Cells[3].Text;
                TextBox2.Text = GridView1.Rows[rowID].Cells[1].Text;
                TextBox6.Text = GridView1.Rows[rowID].Cells[2].Text;
                DropDownList2.Text = GridView1.Rows[rowID].Cells[0].Text;
                SqlConnection con = new SqlConnection(mystring);
                con.Open();
                string delete = "delete from [productList] where productID = '" + TextBox2.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                Response.Write("deleted successfully");
                binddata();
            }

            if (e.CommandName == "Editt")
            {
                int rowID = Convert.ToInt32(e.CommandArgument);
                DropDownList2.Text = GridView1.Rows[rowID].Cells[0].Text;
                TextBox2.Text = GridView1.Rows[rowID].Cells[1].Text;

                TextBox6.Text = GridView1.Rows[rowID].Cells[2].Text;
                TextBox5.Text = GridView1.Rows[rowID].Cells[3].Text;
                DropDownList1.Text = GridView1.Rows[rowID].Cells[4].Text;

                HiddenField1.Value = TextBox2.Text;

            }
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox2.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
        }
    }
    }
