using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using FacadeLayer;
namespace isos_airlines19._11
{
    public partial class master_page : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserInfo"]== null)
            {
                LinkButton1.Visible = false;
            }
            else if (Session["UserInfo"] !=null)
            {
                LinkButton1.Visible = true;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            
            Session["UserInfo"] = null;
            Response.Redirect("default.aspx");
            LinkButton1.Visible = false;
            
        }

    
    }
}