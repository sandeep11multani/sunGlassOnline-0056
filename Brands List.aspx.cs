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
        public string mystring = "Data Source=DESKTOP-9HUANL2\\KHEHRA05;Initial Catalog=newP;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                bindData();

        }
        public void bindData()
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
        

        protected void GridView1_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
          /*  if (e.CommandName == "Deletee")
            {
                int rowID = Convert.ToInt32(e.CommandArgument);
               // TextBox1.Text = GridView1.Rows[rowID].Cells[0].Text;
              //  TextBox2.Text = GridView1.Rows[rowID].Cells[1].Text;

                SqlConnection con = new SqlConnection(mystring);
                con.Open();
               //// string delete = "delete from [brandList] where brandID = '" + TextBox1.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                Response.Write("deleted successfully");
              //  bindDataToGridView();
            }*/
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "Editt")
            {
                Response.Redirect("~/brandEdit.aspx");
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label l1 = GridView1.Rows[e.RowIndex].FindControl("stbl") as Label;
            SqlConnection con = new SqlConnection(mystring);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Delete from brandList where brandID=@id1";
            cmd.Parameters.AddWithValue("@id1", l1.Text);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            bindData();
        }
    }
        }
    