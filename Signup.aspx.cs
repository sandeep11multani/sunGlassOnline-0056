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
        public string mystring = "Data Source=DESKTOP-9HUANL2\\KHEHRA05;Initial Catalog=newP;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Here I will validate Captcha 
            bool isCaptchaValid = false;
            if (Session["CaptchaText"] != null && Session["CaptchaText"].ToString() == txtCaptchaText.Text)
            {
                isCaptchaValid = true;
            }

            if (isCaptchaValid)
            {

                lblMessage.Text = "Captcha Validation Success";
                lblMessage.ForeColor = Color.Green;

                using (SqlConnection con = new SqlConnection(mystring))
                {
                    con.Open();

                    bool exists = false;

                    // create a command to check if the username exists
                    using (SqlCommand cmd = new SqlCommand("select count(*) from signup where username = @username", con))
                    {
                        cmd.Parameters.AddWithValue("username", TextBox1.Text);
                        exists = (int)cmd.ExecuteScalar() > 0;
                    }

                    // if exists, show a message error
                    if (exists)
                    {
                        Label6.Text = "This username has already been used.";
                        Label6.Visible = true;
                    }
                    else
                    {
                        using (SqlConnection sqlCon = new SqlConnection(mystring))
                        {
                            sqlCon.Open();
                            SqlCommand sqlCmd = new SqlCommand("user", sqlCon);
                            sqlCmd.CommandType = CommandType.StoredProcedure;

                            sqlCmd.Parameters.AddWithValue("@username", TextBox1.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@password", TextBox2.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@Cpassword", TextBox3.Text.Trim());
                            sqlCmd.ExecuteNonQuery();
                            // MessageBox.Show("Registration is successfull");
                            Clear();

                        }
                        Response.Redirect("~/login.aspx");
                    }
                }
            }


            lblMessage.Text = "Captcha Validation Failed";
            lblMessage.ForeColor = Color.Red;

        }
                    void Clear()
                    {
                        TextBox1.Text = TextBox2.Text = TextBox3.Text = "";

                    }

        protected void txtCaptchaText_TextChanged(object sender, EventArgs e)
        {

        }

       
    }


}
        

 

    