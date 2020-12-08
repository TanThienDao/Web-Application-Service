using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryitPageTanDao
{
    public partial class ImageVerifier : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Response.Clear();
                ImmageGen.ServiceClient test1 = new ImmageGen.ServiceClient();
                string mystr, userLen;
                if (Session["generatedString"] == null)
                {

                    userLen = "6";                       // Assigning userLen to 6
                    mystr = test1.GetVerifierString(userLen);   // Retreiving a random string
                    Session["generatedString"] = mystr;        // Storing in the session variable
                }
                else
                {
                    mystr = Session["generatedString"].ToString();
                }
                Stream mystream = test1.GetImage(mystr);
                System.Drawing.Image myImage = System.Drawing.Image.FromStream(mystream);  // Draw the image
                Response.ContentType = "image/jpeg";
                myImage.Save(Response.OutputStream, ImageFormat.Jpeg);
                var ms = new MemoryStream();
                mystream.CopyTo(ms);
                System.Web.UI.WebControls.Image img = new System.Web.UI.WebControls.Image();
                
            }
            catch (Exception e1)
            {

            }
        }
    }
}