using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;
using FacadeLayer;

namespace isos_airlines19._11
{
    public partial class _default : System.Web.UI.Page
    {

       
        protected void Page_Load(object sender, EventArgs e)
        {
            #region
            Customer usr = ((Customer)Session["UserInfo"]);
            if (usr != null)
            {
                string info = "Merhaba " + usr.CustomerName_Surname;

                Label1.Text = info;
            }
            if(usr==null)
            {
                Label1.Text = "";
            }
            #endregion

            if (Session["UserInfo"] ==null)
            {
                Label1.Text = "";
            }
            if (!IsPostBack)
                  {
             
                Calendar1.Visible = false;
                Calendar2.Visible = false;
                  }
       

        }

      
        protected void Gidiş_Dönüş_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar1.Visible)
            {
                Calendar1.Visible = false;
            }
            else
            {
                Calendar1.Visible = true;
            }
        }




        protected void fillDropDownList1()
        {

            using (SqlCommand cmd = new SqlCommand("GetAirports", DatabaseConnection.conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DatabaseConnection.conn.Open();
                DropDownList1.DataSource = cmd.ExecuteReader();
                DropDownList1.DataTextField = "AirportName";
                DropDownList1.DataBind();
                DatabaseConnection.conn.Close();

            }
        }
        protected void fillDropDownList2()
        {

            using (SqlCommand cmd = new SqlCommand("GetAirports", DatabaseConnection.conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DatabaseConnection.conn.Open();
                DropDownList2.DataSource = cmd.ExecuteReader();
                DropDownList2.DataTextField = "AirportName";
                DropDownList2.DataBind();
                DatabaseConnection.conn.Dispose();
                DatabaseConnection.conn.Close();

            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;                
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar2.Visible)
            {
                Calendar2.Visible = false;
            }
            else
            {
                Calendar2.Visible = true;
            }

           
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            TextBox2.Text = Calendar2.SelectedDate.ToShortDateString();
            Calendar2.Visible = false;
        }

        protected void TekYon_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
    
                Calendar2.Visible = false;
                TextBox2.Visible = false;
                ImageButton2.Visible = false;
         



        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Session["date"] = TextBox1.Text.ToString();
            Session["a_name"] = DropDownList1.SelectedValue.ToString();
            Session["d_name"] = DropDownList2.SelectedValue.ToString();
            Response.Redirect("~/UcusSec.aspx");

        }
    }
}