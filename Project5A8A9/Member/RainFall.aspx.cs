using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5A8A9.Member
{
    public partial class RainFall : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PopulationButton_Click(object sender, EventArgs e)
        {
            TanDaoServices.Service1Client proxy = new TanDaoServices.Service1Client();
            if (!string.IsNullOrWhiteSpace(LocationNameBox.Text))
            {
                ResultRainCondition.Text = proxy.RainFall(LocationNameBox.Text);
            }
            else
            {
                ResultRainCondition.Text = "Please enter Location!";
            }
        }
    }
}