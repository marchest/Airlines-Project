using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using EntityLayer;
using FacadeLayer;
using System.Net.Mail;
namespace isos_airlines19._11
{
    public partial class MemberSign : System.Web.UI.Page
    {

      
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.CustomerName_Surname = TextBox1.Text;
            c.C_Mail = TextBox2.Text;
            c.Customer_Password = TextBox3.Text;
            Class1.addUser(c);
            TextBox1.Text = "";
            TextBox2.Text = "";

        }

        protected void button2_Click(object sender, EventArgs e)
        {
         Customer usr = Class1.GetUser(TextBox4.Text, TextBox5.Text);

            if (usr == null)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Böyle bir kullanıcı yoktur.');", true);
            }
            else
            {
                Session["UserInfo"] = usr;
                if (usr.CustomerName_Surname=="admin")
                {
                    Response.Redirect("~/admin.aspx");
                }
                else
                    Response.Redirect("~/default.aspx");
            }

        }
    }
}