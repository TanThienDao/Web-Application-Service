using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using DllCrypto;

namespace Project5A8A9.Member
{
    public partial class MemberRegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ResultLabel.Text = Session["generateString"].ToString();

          
        }

        protected void CreateButton_Click(object sender, EventArgs e)
        {
            bool resultM= false;

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
                            int role = 1;
                            String response = proxy2.addAcoundt(UserNameBox.Text, PasswordBox.Text, role);
                            if (response.Equals("success"))
                            {
                                Session["registration"] = "success";
                                ResultLabel.Text = "Sucessfull Create Member accound ";
                                Response.Redirect("Login.aspx");
                            }
                            else if (response.Equals("exist"))
                            {
                                ResultLabel.Text = "The User name already exit! Pleae choose different user name. ";
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
            catch(Exception ex)
            {
                ResultLabel.Text = ex.ToString();
            }
        }
        public bool addMember(string username, string password)
        {
            bool result=false;
            string encryptPass=DllCrypto.Class1.Encrypt(password);
            Accound addMember = new Accound();
            addMember.UserName = username;
            addMember.Password = encryptPass;
            string addData = HttpRuntime.AppDomainAppPath + "App_Data/Member.xml";
            XmlDocument xd = new XmlDocument();
            xd.Load(addData);
            try
            {
                XElement xml = XElement.Load(addData);
                xml.Add(new XElement("Member",
                    new XElement("user_name", addMember.UserName),
                    new XElement("password",addMember.Password)
                    ));
                result = true;
                xml.Save(addData);
            }
            catch(Exception ex)
            {
                result = false;
            }
            





            return result;
        }
        public class Accound
        {
            private string _username;
            private string _password;

            public string UserName
            {
                get { return _username; }
                set { _username = value; }
            }
            public string Password
            {
                get { return _password; }
                set { _password = value; }
            }

        }

    }
}