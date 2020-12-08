using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5A8A9.Account
{
    public partial class Login : System.Web.UI.Page
    {
        public static string usernameMaster = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            ServiceDeplyTanDao.Service1Client proxy = new ServiceDeplyTanDao.Service1Client();
            if (proxy.myAuthenticate(UserBox.Text, PassBox.Text))
            {
                HttpCookie myCookie = new HttpCookie("StaffCookieID");
                myCookie.Expires = DateTime.Now.AddMonths(-7);
                Response.Cookies.Add(myCookie);
                myCookie = new HttpCookie("MemberCookieID");
                FormsAuthentication.RedirectFromLoginPage(UserBox.Text, CheckBox1.Checked);
                usernameMaster = UserBox.Text;
                //SiteMaster.SetName(usernameMaster);
                myCookie["Name"] = UserBox.Text;
                myCookie["Pass"] = DllCrypto.Class1.Encrypt(PassBox.Text);
                myCookie.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(myCookie);
                Session["username"] = UserBox.Text;
                Session["role"] = "1";
                //Response.Redirect("Member/Member.aspx");
            }
            else
            {
                MessageLabel.Text = "Invalid Username or passowrd.";
            }
        }
    }
}