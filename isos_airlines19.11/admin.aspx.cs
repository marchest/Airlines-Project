using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FacadeLayer;
using EntityLayer;
using BusinessLayer;
namespace isos_airlines19._11
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
            GridView1.Visible = false;
            GridView2.Visible = false;
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            cus.CustomerName_Surname = TextBox1.Text;
            cus.C_Mail = TextBox2.Text;
            Class1.DeleteUser(cus);
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            cus.CustomerName_Surname = TextBox3.Text;
            cus.C_Mail = TextBox4.Text;
            cus.Customer_Password = TextBox5.Text; 
            Class1.updateInfo(cus);
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            Label1.Text = "işlem başarılı";
        }
      
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
          
                GridView1.Visible = true;
          
        
           
        }
      
        protected void LinkButton5_Click(object sender, EventArgs e)
        {
       
                GridView2.Visible = true;
          
              
           
        }
    }
}