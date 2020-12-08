using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5A8A9.Account
{
    public partial class Manament : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie myCookie = new HttpCookie("StaffCookieID");
            myCookie.Expires = DateTime.Now.AddMonths(-7);
            Response.Cookies.Add(myCookie);
            myCookie = new HttpCookie("MemberCookieID");
            myCookie.Expires = DateTime.Now.AddMonths(-7);
            Response.Cookies.Add(myCookie);
            Session["role"] = "0";

        }
    }
}