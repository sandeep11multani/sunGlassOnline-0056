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
        public string mystring = "Data Source=desktop-6ddcjgt;Initial Catalog=sunglassonline;Integrated Security=True";
       
        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "select * from productListt";
            SqlConnection con = new SqlConnection(mystring);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
             //GridView1.DataSource = ds;
             //GridView1.DataBind();
            con.Close();
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = "UPDATE productListt SET productID='" + TextBox2.Text + "',productName='" + TextBox6.Text + "',salesprice='" + TextBox5.Text + "',availableQuantity='" + DropDownList1.SelectedValue + "', brand = '" + DropDownList2.SelectedValue + "' where productName='"+HiddenField1.Value.ToString()+"'";


            SqlConnection con = new SqlConnection(mystring);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("brand", DropDownList2.SelectedItem.Value);
            TextBox6.Text = "";
            TextBox2.Text = "";
            TextBox5.Text = "";
            cmd.Parameters.AddWithValue("availableQuantity", DropDownList1.SelectedItem.Value);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
           // GridView1.DataSource = ds;
            //GridView1.DataBind();
            con.Close();
        }


        public void BindData()
        {
            SqlConnection con = new SqlConnection(mystring);
            SqlCommand cmd = new SqlCommand();
            con = new SqlConnection(mystring);
            cmd.CommandText = "Select * from productListt";
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Open();
            cmd.ExecuteNonQuery();
           // GridView1.DataSource = ds;
            //GridView1.DataBind();
            con.Close();
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

            GridView1.PageIndex = e.NewPageIndex;   
            BindData();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
            {
            DropDownList2.SelectedValue = GridView1.SelectedRow.Cells[1].Text;
            TextBox2.Text = GridView1.SelectedRow.Cells[2].Text;
            TextBox5.Text = GridView1.SelectedRow.Cells[4].Text;
            TextBox6.Text = GridView1.SelectedRow.Cells[3].Text;
            DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[5].Text;
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            SqlConnection con = new SqlConnection(mystring);
            SqlCommand cmd = new SqlCommand();
            con = new SqlConnection(mystring);
            cmd.Connection = con;
            cmd.CommandText = "Delete from productListt where productID='" + TextBox2.Text + "'";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            BindData();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindData();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            SqlConnection con = new SqlConnection(mystring);
            SqlCommand cmd = new SqlCommand();
            con = new SqlConnection(mystring);
            DropDownList DropDownList2 = (DropDownList)GridView1.Rows[e.RowIndex].FindControl("brand");
            TextBox Textbox6 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("productName");
            TextBox Textbox2 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("productID");
            TextBox Textbox5 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("salesPrice");
            DropDownList DropDownList1 = (DropDownList)GridView1.Rows[e.RowIndex].FindControl("availableQuantity");
            cmd.Connection = con;
            cmd.CommandText = "UPDATE productListt SET productID='" + TextBox2.Text + "',productName='" + TextBox6.Text + "',salesprice='" + TextBox5.Text + "',availableQuantity='" + DropDownList1.SelectedItem + "' WHERE brand = '" + DropDownList2.SelectedItem + "'";
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            GridView1.EditIndex = -1;
            BindData();
            con.Close();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindData();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
            {

            }
        }
    }
