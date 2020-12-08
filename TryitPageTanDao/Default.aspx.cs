using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace TryitPageTanDao
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void createButton_Click(object sender, EventArgs e)
        {
            TanDaoServices.Service1Client proxy2 = new TanDaoServices.Service1Client();
            try
            {
                if (!Session["generatedString"].Equals(StringVerifyBox.Text))
                {
                    MessageLabel1.Text = "The string enter is incorrect, try it again!";
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(USerCOnBox.Text) &&
                        !string.IsNullOrWhiteSpace(PassCOnBox.Text) &&
                        !string.IsNullOrWhiteSpace(ConfirmPassBox.Text))
                    {
                        if (ConfirmPassBox.Text == PassCOnBox.Text)
                        {
                            int role = 1;
                            String response = proxy2.addAcoundt(USerCOnBox.Text, PassCOnBox.Text, role);
                            if (response.Equals("success"))
                            {
                                Session["registration"] = "success";
                                MessageLabel1.Text = "Sucessfull Create Member accound ";

                            }
                            else if (response.Equals("exist"))
                            {
                                MessageLabel1.Text = "The User name already exit! Pleae choose different user name. ";
                            }
                        }
                    }
                    else
                    {
                        MessageLabel1.Text = "PLease enter all require!";
                    }
                }

            }
            catch (Exception ex) { }

        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                TanDaoServices.Service1Client proxy = new TanDaoServices.Service1Client();
                string[] response = new string[2];
                response = proxy.search(logUsernameBox.Text, 1);
                if (response[0].Equals("notFound"))
                {
                    MessageLabel2.Text = "User names does not exit !";
                }
                else if (response[0].Equals(logUsernameBox.Text))
                {
                    HttpCookie myCookie = new HttpCookie("StaffCookieID");
                    myCookie.Expires = DateTime.Now.AddMonths(-7);
                    Response.Cookies.Add(myCookie);
                    myCookie = new HttpCookie("MemberCookieID");
                    string pass = response[1];
                    pass = proxy.Decrypt(pass);
                    //pass = DllCrypto.Class1.Decrypt(pass);
                    if (passlogBox.Text.Equals(pass))
                    {
                        myCookie["Name"] = logUsernameBox.Text;
                        myCookie["Pass"] = proxy.Encrypt(passlogBox.Text);
                        myCookie.Expires = DateTime.Now.AddMonths(6);
                        Response.Cookies.Add(myCookie);
                        Session["username"] = logUsernameBox.Text;
                        Session["role"] = "1";
                        MessageLabel2.Text = "Accound login!";

                    }
                    else
                    {
                        MessageLabel2.Text = "Incorrect password !";
                    }


                }
                else
                {
                    MessageLabel2.Text = response[0].ToString();
                }


            }
            catch (Exception ex)
            {
                MessageLabel2.Text = ex.Message;
            }
        }

        protected void returnxmlButton_Click(object sender, EventArgs e)
        {
            TextBox3.Text = "";
            string re = "",ro="";
            try
            {
                if (TextBox4.Text == "Member.xml")
                {
                    re = "Member.xml";
                    ro = "//Member";
                }
                else if (TextBox4.Text == "Staff.xml")
                {
                    re = "Staff.xml";
                    ro = "//Staff";
                }
                else
                {
                    TextBox3.Text = "type Member.xml or Staff.xml only";
                }

                TanDaoServices.Service1Client displayService = new TanDaoServices.Service1Client();

                string xmlToDisplay = displayService.returnXML(re);

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(xmlToDisplay);


                foreach (XmlNode node in xmlDoc.SelectNodes("//Member"))
                {
                    TextBox3.Text += " Username:    " + node["user_name"].InnerText + "\n";
                }
            }
            catch (Exception ex) { }
        }
    }
}