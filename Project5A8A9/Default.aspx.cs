using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5A8A9
{
    public partial class _Default : Page
    {
        public static int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["registration"] = "";
            Session["registration1"] = "";
            if(count ==0)
            {
                Session["role"] = "0";
            }
            count++;
            //Response.Write(Session["role"].ToString());


            StartTimeLabel.Text = "The Application was last accessed at: " + Application["ApplicationStartTime"];
            AccessRequestLabel.Text = "The amount of Access Requests: " + (int)Application["accessrequest"];
        }

        protected void MemberPageButton_Click(object sender, EventArgs e)
        {
            //Response.Redirect("Member/Member.aspx");
            try
            {
                HttpCookie Cookie = Request.Cookies["MemberCookieID"];

                if((Cookie == null)|| Session["role"].Equals(null) || (Session["role"].ToString() != "1"))
                {
                    Response.Redirect("Member/Login.aspx");
                }
                else if((Session["role"].ToString() == "1"))
                {
                    Response.Redirect("Member/Member.aspx");
                } 
                //Response.Redirect("Member/Login.aspx");
            }
            catch(Exception ex)
            {

            }
        }

        protected void StaffPageButton_Click(object sender, EventArgs e)
        {
            //Response.Redirect("/Staff/StaffPage.aspx");
            try
            {
                HttpCookie StafCookie = Request.Cookies["StaffCookieID"];
                if ((StafCookie == null) || (!Session["role"].Equals("2") || Session["role"].Equals(null)))
                {
                    Response.Redirect("Staff/StaffLogin.aspx");
                }
                else if ((Session["role"].Equals ("2")))
                {
                    Response.Redirect("Staff/StaffPage.aspx");
                }
            }
            catch (Exception ex)
            {

            }
            //Response.Redirect("Staff/StaffLogin.aspx");
        }

        protected void MemberRegistrationButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Member/MemberRegisterPage.aspx");
        }

        protected void StaffRRegistrationButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Staff/StaffRegisterPage.aspx");


          
        }
    }
}