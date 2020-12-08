using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5A8A9.Staff
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

                    userLen = "7";                       
                    mystr = test1.GetVerifierString(userLen);   
                    Session["generatedString"] = mystr;        
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
                //img.ImageUrl = $"data:image/jpeg;base64,{b64Image}";
                //Panel.Controls.Add(img);
            }
            catch (Exception e1)
            {

            }
        }
    }
}