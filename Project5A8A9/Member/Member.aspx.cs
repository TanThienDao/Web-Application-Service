using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5A8A9.Member
{
    public partial class Member : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["role"]==null  || !Session["role"].Equals("1")|| Request.Cookies["MemberCookieID"]==null)
            {
                Response.Redirect("MemberUnauthorize.aspx");
            }
            WelcomeLabel.Text = "Welcome "+Session["username"].ToString() +" to Member page!";
        }
    }
}