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
    public partial class editbrand : System.Web.UI.Page
    {
        public string mystring = "Data Source=desktop-6ddcjgt;Initial Catalog=sunglassonline;Integrated Security=True";
        //public int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "select * from Blist";
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

       
        
        
        
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
           
        }
         
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(mystring);
            con.Open();

           
           
            string a = "update Blist set brandName= '" + TextBox2.Text.ToString() + "',brandID='" + TextBox1.Text.ToString() + "'";
            SqlCommand cmd = new SqlCommand(a, con);
            cmd.CommandText = a;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            TextBox1.Text="";
            TextBox2.Text="";
            string query = "select * from Blist";
            SqlConnection con1 = new SqlConnection(mystring);
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = query;
            cmd1.Connection = con1;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con1.Close();
            GridView1.EditIndex = -1;
            GridView1.DataBind();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.SelectedRow.Cells[1].Text;
            TextBox2.Text = GridView1.SelectedRow.Cells[2].Text;
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/inventory.aspx");
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.SelectedRow.Cells[1].Text;
            TextBox2.Text = GridView1.SelectedRow.Cells[2].Text;

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

        protected void GridView1_SelectedIndexChanged2(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(mystring);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Blist";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da1.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                TextBox1.Text = dr["brandID"].ToString();
                TextBox2.Text = dr["brandName"].ToString();
            }
            
            TextBox1.Text = GridView1.SelectedRow.Cells[1].Text;
            TextBox2.Text = GridView1.SelectedRow.Cells[2].Text;
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}