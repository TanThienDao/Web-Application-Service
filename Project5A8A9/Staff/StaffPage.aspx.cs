using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Project5A8A9.Staff
{
    public partial class StaffPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["role"] == null || !Session["role"].Equals("2") || Request.Cookies["StaffCookieId"] == null)
            {
                Response.Redirect("StaffUnauthorize.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceDeplyTanDao.Service1Client addService = new ServiceDeplyTanDao.Service1Client();
            try
            {
                if (addService.addAcoundt(TextBox1.Text, TextBox2.Text, 1) == "success")
                {
                    Label1.Text = "Successfully Added New User!";
                    Label1.ForeColor = System.Drawing.Color.Green;
                }
                else if (addService.addAcoundt(TextBox1.Text, TextBox2.Text, 1) == "exist")
                {
                    Label1.Text = "Member Already Exists, Failed to Add";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    Label1.Text = "Something Went Wrong :( Failed to Add";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
                Label1.Visible = true;
            }
            catch(Exception ex)
            {
                Label1.Text = ex.ToString();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceDeplyTanDao.Service1Client deleteService = new ServiceDeplyTanDao.Service1Client();
            try
            {
                if (deleteService.removeFromXML(TextBox1.Text, 1))
                {
                    Label1.Text = "Successfully Deleted User!";
                    Label1.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    Label1.Text = "Something Went Wrong :( Failed to Delete User";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
                Label1.Visible = true;
            }
            catch(Exception ex)
            {
                Label1.Text = ex.ToString();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ServiceDeplyTanDao.Service1Client searchService = new ServiceDeplyTanDao.Service1Client();
            try
            {
                if (searchService.search(TextBox1.Text, 1)[0] == "notFound")
                {
                    Label1.Text = "Failed to Find User";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    Label1.Text = "Successfully Found User!";
                    Label1.ForeColor = System.Drawing.Color.Green;
                }
                Label1.Visible = true;
            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //Clear contents
            TextBox3.Text = "";

            ServiceDeplyTanDao.Service1Client displayService = new ServiceDeplyTanDao.Service1Client();

            string xmlToDisplay = displayService.returnXML("Member.xml");

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlToDisplay);


            foreach (XmlNode node in xmlDoc.SelectNodes("//Member"))
            {
                TextBox3.Text += "Member Username:    " + node["user_name"].InnerText + "\n";
            }
        }
    }
}