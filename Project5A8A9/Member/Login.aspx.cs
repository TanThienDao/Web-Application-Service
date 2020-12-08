using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DllCrypto;

namespace Project5A8A9.Member
{
    public partial class Login : System.Web.UI.Page
    {
        string v = "registration";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session[v].Equals("success"))
            {
                MessageLabel.Text = "Registration Successful! PLease login.";
                Session[v] = "";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceDeplyTanDao.Service1Client proxy = new ServiceDeplyTanDao.Service1Client();
                string[] response = new string[2];
                response = proxy.search(UserBox.Text, 1);
                if(response[0].Equals("notFound"))
                {
                    MessageLabel.Text = "User names does not exit !";
                }
                else if(response[0].Equals(UserBox.Text))
                {
                    HttpCookie myCookie = new HttpCookie("StaffCookieID");
                    myCookie.Expires = DateTime.Now.AddMonths(-7);
                    Response.Cookies.Add(myCookie);
                    myCookie = new HttpCookie("MemberCookieID");
                    string pass = response[1];
                    pass = DllCrypto.Class1.Decrypt(pass);
                    if(PassBox.Text.Equals(pass))
                    {
                        myCookie["Name"] = UserBox.Text;
                        myCookie["Pass"] = DllCrypto.Class1.Encrypt(PassBox.Text);
                        myCookie.Expires = DateTime.Now.AddMonths(6);
                        Response.Cookies.Add(myCookie);
                        Session["username"] = UserBox.Text;
                        Session["role"] = "1";
                        Response.Redirect("Member.aspx");

                    }
                    else
                    {
                        MessageLabel.Text = "Incorrect password !";
                    }
                    
                    
                }
                else
                {
                   MessageLabel.Text= response[0].ToString();
                }


            }
            catch(Exception ex)
            {
                MessageLabel.Text = ex.Message;
            }
        }
    }
}