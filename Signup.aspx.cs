using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using BotDetect.Web.Mvc;


namespace Sunglasses_Online
{
    public partial class Signup : System.Web.UI.Page
    {
        // private string code;
        public string mystring = "Data Source=desktop-9huanl2\\khehra05;Initial Catalog=newP;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ExampleCaptcha.UserInputID = CaptchaCodeTextBox.ClientID;
            if (IsPostBack)
            {
                // validate the Captcha to check we're not dealing with a bot 
                bool isHuman = ExampleCaptcha.Validate(CaptchaCodeTextBox.Text);

                CaptchaCodeTextBox.Text = null; // clear previous user input 

                if (!isHuman)
                {

                    // TODO: Captcha validation failed, show error message  
                }
                else
                {
                    // TODO: Captcha validation passed, proceed with protected action 
                    MvcCaptcha.ResetCaptcha("ExampleCaptcha");
                }
            }
            if (TextBox1.Text == "" || TextBox2.Text == "") ;
            // MessageBox.Show("please fill mandatory fields");
            else if (TextBox2.Text != TextBox3.Text) ;
            // MessageBox.Show("Password do not match");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(mystring))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("user", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    sqlCmd.Parameters.AddWithValue("@Cpassword", TextBox3.Text.Trim());

                    sqlCmd.Parameters.AddWithValue("@username", TextBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@password", TextBox2.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    // MessageBox.Show("Registration is successfull");
                    Clear();
                    Response.Redirect("~/WebForm2.aspx");

                }
            }
        }
        void Clear()
        {
            TextBox1.Text = TextBox2.Text = TextBox3.Text = "";

        }

        /*
        SqlConnection con = new SqlConnection(mystring);
        con.Open();
        if (con.State == System.Data.ConnectionState.Open)
        {
            string a = "insert into signup (username, password,confirmpassword) values(" + TextBox1.Text.ToString() + "," + TextBox2.Text.ToString() + "," + TextBox3.Text.ToString() + ")";
            SqlCommand cmd = new SqlCommand(a, con);
            cmd.ExecuteNonQuery();
            Response.Write("congratulations you did signup successfully");
            
              Response.Redirect("~/Login.aspx");
        }*/


    }
    }


 

    