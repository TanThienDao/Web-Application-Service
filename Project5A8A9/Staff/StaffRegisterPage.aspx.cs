using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5A8A9.Staff
{
    public partial class StaffRegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void CreateButton_Click(object sender, EventArgs e)
        {
            ServiceDeplyTanDao.Service1Client proxy2 = new ServiceDeplyTanDao.Service1Client();
            try
            {
                if (!Session["generatedString"].Equals(VerifyStringBox.Text))
                {
                    ResultLabel.Text = "The string enter is incorrect, try it again!";
                }
                else
                {
                    ResultLabel.Text = Session["generatedString"].ToString();

                    if (!String.IsNullOrWhiteSpace(UserNameBox.Text) &&
                        !String.IsNullOrWhiteSpace(ConfirmPassBox.Text) &&
                        !String.IsNullOrWhiteSpace(PasswordBox.Text))
                    {
                        if (ConfirmPassBox.Text == PasswordBox.Text)
                        {
                            int role = 2;
                            String response = proxy2.addAcoundt(UserNameBox.Text, PasswordBox.Text, role);
                            if (response.Equals("success"))
                            {
                                Session["registration1"] = "success";
                                ResultLabel.Text = "Sucessfull Create Member accound ";
                                Response.Redirect("StaffLogin.aspx");
                            }
                            else if (response.Equals("exist"))
                            {
                                ResultLabel.Text = "The User name already exit! Please choose different user name. ";
                            }


                        }
                        else
                        {
                            ResultLabel.Text = "Password and Confirm Password does not match!" + ConfirmPassBox.Text + " " +
                                PasswordBox.Text;

                        }
                    }
                    else
                    {
                        ResultLabel.Text = "PLease enter all require!";
                    }
                }
            }
            catch (Exception ex)
            {
                ResultLabel.Text = ex.ToString();
            }
        }
    }
}