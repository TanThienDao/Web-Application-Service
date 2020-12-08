using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5A8A9.Member
{
    public partial class Account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreatedButton_Click(object sender, EventArgs e)
        {
            TanDaoServices.Service1Client proxy = new TanDaoServices.Service1Client();
            if (!string.IsNullOrWhiteSpace(UsernameBox.Text) && !string.IsNullOrWhiteSpace(PasswordBox.Text))
            {
                bool create = proxy.AccontService(UsernameBox.Text, PasswordBox.Text);
                if (create)
                {
                    ResultLabel.Text = "Account creates sucessful.";
                }
                else
                {
                    ResultLabel.Text = "Username already exit, please enter different username.";
                }
            }
            else
            {
                ResultLabel.Text = "Please enter your infomation. ";
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            TanDaoServices.Service1Client proxy = new TanDaoServices.Service1Client();
            if (!string.IsNullOrWhiteSpace(TextBox1.Text) && !string.IsNullOrWhiteSpace(TextBox2.Text))
            {
                bool[] login = proxy.LoginService(TextBox1.Text, TextBox2.Text);
                if (login[0] && login[1])
                {
                    ResultLabel.Text = "Login sucessful!";
                }
                else if (login[0] && !login[1])
                {
                    ResultLabel.Text = "Wrong Password!";
                }
                else if (!login[0])
                {
                    ResultLabel.Text = "Account does not exits! Please create new account.";
                }
                else
                {
                    ResultLabel.Text = "something I did not know ?";
                }
            }
            else
            {
                ResultLabel.Text = "Please enter Info!";
            }
        }
    }
}