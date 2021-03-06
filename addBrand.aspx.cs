﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication7
{
    public partial class addBrand : System.Web.UI.Page
    {
        public string mystring = "Data Source=desktop-c94h52l\\sqlexpress;Initial Catalog=myproject;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                bindData();
        }
            protected void bindData()
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

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
         using (SqlConnection con = new SqlConnection(mystring))
                    {
                        con.Open();

                        bool exists = false;

                        // create a command to check if the username exists
                        using (SqlCommand cmd = new SqlCommand("select count(*) from brandList where brandID = @brandID", con))
                        {
                            cmd.Parameters.AddWithValue("brandID", TextBox2.Text);
                            exists = (int)cmd.ExecuteScalar() > 0;
                        }

                        // if exists, show a message error
                        if (exists)
                        {
                            Label4.Text = "ID already exist";
                            Label4.Visible = true;
                        }
                        else
                        {
                    //using (SqlConnection con = new SqlConnection(mystring);
                         //con.Open();
                         SqlCommand cmd = con.CreateCommand();
                         cmd.CommandType = CommandType.Text;
                         cmd.CommandText = " insert into brandList values('" + TextBox2.Text + "','" + TextBox3.Text + "')";
                         cmd.ExecuteNonQuery();
                         con.Close();
                         TextBox3.Text = "";
                         TextBox2.Text = "";
                         bindData();

                        }
                    }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
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
            Response.Redirect("~/login.aspx");
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            
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

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editt")
            {
                Response.Redirect("~/brandEdit.aspx");
            }
        }
    }
}