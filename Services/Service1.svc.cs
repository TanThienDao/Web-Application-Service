using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using DllCrypto;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

       
        // testing Dll Libary 
        public string Encrypt(string plaintext)
        {
            string result = DllCrypto.Class1.Encrypt(plaintext);
            return result;
        }
        public string Decrypt(string encryptedText)
        {
            string result = DllCrypto.Class1.Decrypt(encryptedText);
            return result;
        }

        // service develop.

        public double GetWindEnergyIndex(Int32 lattitude, Int32 longitude)
        {
            
            int rowNo = ((lattitude + 90) * 360) + (longitude + 180) + 1;
            int actualRowNo = rowNo + 7;
            int rowsTobeSkipped = actualRowNo - 1;
            string annualIndex = "";
            string path = Path.Combine(System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath, "App_Data", "10yr_wspd50m");

            
            if (File.Exists(path))
            {
                string rowContent = File.ReadLines(path).Skip(rowsTobeSkipped).Take(1).First();
                annualIndex = rowContent.Substring(rowContent.LastIndexOf(" "));
            }
            return Convert.ToDouble(annualIndex);

        }
        public string GetVerifierString(string length)
        {
            // This service is used to obtain random string 
            Uri baseUri = new Uri("http://neptune.fulton.ad.asu.edu/WSRepository/Services/RandomString/Service.svc/");
            UriTemplate myTemplate = new UriTemplate("GetRandomString/{len}");
            Uri completeUri = myTemplate.BindByPosition(baseUri, length); // Assign value to variable to obtain complete URI
            WebClient proxy = new WebClient();
            byte[] response = proxy.DownloadData(completeUri);
            Stream strm = new MemoryStream(response); // Convert to memory stream
            DataContractSerializer obj = new DataContractSerializer(typeof(string));
            string randstring = obj.ReadObject(strm).ToString();
            return randstring;
        }

        public Stream GetImage(string myString)
        {
            WebOperationContext.Current.OutgoingResponse.ContentType = "image/jpeg";
            int mapwidth = (int)(myString.Length * 25);  // Create bitmap
            Bitmap bmap = new Bitmap(mapwidth, 40); // Based on string length
            Graphics graph = Graphics.FromImage(bmap);
            graph.Clear(Color.Azure);  // Background Color
            graph.DrawRectangle(new Pen(Color.LightBlue, 0), 0, 0, bmap.Width - 1, bmap.Height - 1); // draw an image
            Random rand = new Random();
            Pen badPen = new Pen(Color.LightGreen, 0);
            for (int i = 0; i < 100; i++)  // Create noise pattern
            {
                int x = rand.Next(1, bmap.Width - 1);
                int y = rand.Next(1, bmap.Height - 1);
                graph.DrawRectangle(badPen, x, y, 4, 3);
                graph.DrawEllipse(badPen, x, y, 2, 3);
            }

            char[] charstring = myString.ToCharArray();
            Font font = new Font("Boopee", 18, FontStyle.Bold);
            Color[] clr = { Color.Black, Color.Red, Color.DarkGreen, Color.DarkViolet, Color.DarkOrange, Color.Brown, Color.DarkGoldenrod, Color.Plum };
            // Draw chraaters as graphic objects
            for (int i = 0; i < myString.Length; i++)
            {
                int d = rand.Next(20, 25); // distance between characters
                int p = rand.Next(1, 15); // up and down position
                int c = rand.Next(0, 7);  // Randomly choose a color
                string strl = Convert.ToString(charstring[i]);
                Brush b = new System.Drawing.SolidBrush(clr[c]);
                graph.DrawString(strl, font, b, 1 + i * d, p);

            }
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            bmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            ms.Position = 0;
            graph.Dispose();
            bmap.Dispose();
            return ms;
        }

        public string addAcoundt(string username,string password,int role)
        {
            string result = "";
            string xmlFile = null;
            string PaM = "",pa="";
            if(role ==1)
            {
                xmlFile = "Member.xml";
                PaM = "Members/Member/";
                pa = "Member";

            }
            else if(role == 2)
            {
                xmlFile = "Staff.xml";
                PaM = "Staffs/Staff/";
                pa = "Staff";

            }
            
            string encryptPass = DllCrypto.Class1.Encrypt(password);
            Accound addMember = new Accound();
            addMember.UserName = username;
            addMember.Password = encryptPass;
            string addData = HttpRuntime.AppDomainAppPath + "App_Data/"+xmlFile;
            XmlDocument xd = new XmlDocument();
            xd.Load(addData);
            //XmlNode user_node = xd.CreateElement()
            XmlNodeList userList = xd.SelectNodes(PaM+"user_name");
            foreach(XmlNode user in userList)
            {
                if(user.InnerText == username)
                {
                   return result = "exist";
                }
            }

            try
            {
                XElement xml = XElement.Load(addData);
                xml.Add(new XElement(pa,
                    new XElement("user_name", addMember.UserName),
                    new XElement("password", addMember.Password)
                    ));
                
                xml.Save(addData);
                 return result = "success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            //return result;
            
        }
        public class Accound
        {
            private string _username;
            private string _password;
            private int role = 0;

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

        public string[] search(string username, int role)
        {
            string[] res = new string[2];
            res[0] = "notFound";
            res[1] = "notFound";
            int count = 0;
            List<string> usernameList = new List<string>();
            List<string> passwordList = new List<string>();
            string xmlFile = null; ;
            string PaM = "";
            if (role == 1)
            {
                xmlFile = "Member.xml";
                PaM = "Members/Member/";

            }
            else if (role == 2)
            {
                xmlFile = "Staff.xml";
                PaM = "Staffs/Staff/";

            }
            string addData = HttpRuntime.AppDomainAppPath + "App_Data/" + xmlFile;
            XmlDocument xd = new XmlDocument();
            xd.Load(addData);
            XElement xml = XElement.Load(addData);
            foreach (XElement ele in xml.Descendants("user_name"))
            {
                //Console.WriteLine(ele);
                usernameList.Add((string)ele);
            }
            foreach (XElement ele in xml.Descendants("password"))
            {
                //Console.WriteLine(ele);
                passwordList.Add((string)ele);
            }
            for (int i = 0; i < usernameList.Count; i++)
            {
                if (username == usernameList[i])
                {
                    count = i;
                    res[1] = passwordList.ElementAt<string>(count);
                    res[0] = usernameList[count];
                }
                
            }
            
            return res;
        }

        public bool removeFromXML(string username,int role)
        {
            bool result = false;
            string xmlFile = null;
            string PaM = "";
            string path = "";
            if (role == 1)
            {
                xmlFile = "Member.xml";
                PaM = "Members/Member/";
                path = "/Members/Member[user_name='";

            }
            else if (role == 2)
            {
                xmlFile = "Staff.xml";
                PaM = "Staffs/Staff/";

            }
            string addData = HttpRuntime.AppDomainAppPath + "App_Data/" + xmlFile;
            XmlDocument doc = new XmlDocument();
            doc.Load(addData);
            //XElement xelement = XElement.Load(@"C:\Users\Aurelio\Desktop\TestAPI\ConsoleApp1\XMLFile1.xml");
            // find a node - here the one with name='abc'
            //XmlNode xelement.SelectSingleNode("/Snippets/Snippet[@name='abc']");

            // find a node - here the one with name='abc'
            //XmlNode node = doc.SelectSingleNode("/Members/Member[@user_name= " + "'" + username + "']");
            XmlNode node = doc.SelectSingleNode(path + username + "'" + "]");

            // if found....
            if (node != null)
            {
                // get its parent node
                XmlNode parent = node.ParentNode;

                // remove the child node
                parent.RemoveChild(node);

                // verify the new XML structure
                string newXML = doc.OuterXml;

                // save to file or whatever....
                doc.Save(addData);
                return result = true;
            }

            return result;
        }
        public string returnXML(string xmlfile)
        {
            XmlDocument xd = new XmlDocument();
            
            string result="";
            if (xmlfile == "Member.xml")
            {
                string addData = HttpRuntime.AppDomainAppPath + "App_Data/Member.xml";
                
                xd.Load(addData);
                using (StringWriter sw = new StringWriter())
                {
                    using (XmlTextWriter tx = new XmlTextWriter(sw))
                    {
                        xd.WriteTo(tx);
                        string strXmlText = sw.ToString();
                        result= strXmlText;
                    }
                }
                
            }
            else if(xmlfile == "Staff.xml")
            {
                string addData = HttpRuntime.AppDomainAppPath + "App_Data/Staff.xml";
              
                xd.Load(addData);
                using (StringWriter sw = new StringWriter())
                {
                    using (XmlTextWriter tx = new XmlTextWriter(sw))
                    {
                        xd.WriteTo(tx);
                        string strXmlText = sw.ToString();
                        result= strXmlText;
                    }
                }
            }
            return result;
            
        }
        public bool myAuthenticate(string username, string password)
        {
            int count = 0;
            string[] res = new string[2];
            List<string> usernameList = new List<string>();
            List<string> passwordList = new List<string>();
            string appData = HttpRuntime.AppDomainAppPath + "App_Data/Member.xml";
            XmlDocument xd = new XmlDocument();
            xd.Load(appData);
            bool check = false;

            XElement xml = XElement.Load(appData);
            foreach (XElement ele in xml.Descendants("user_name"))
            {
                //Console.WriteLine(ele);
                usernameList.Add((string)ele);
            }
            foreach (XElement ele in xml.Descendants("password"))
            {
                //Console.WriteLine(ele);
                passwordList.Add((string)ele);
            }
            for (int i = 0; i < usernameList.Count; i++)
            {
                if (username == usernameList[i])
                {
                    count = i;
                    res[1] = passwordList.ElementAt<string>(count);
                    res[0] = usernameList[count];
                }

            }
            string passcheck = res[1].ToString();
            passcheck = DllCrypto.Class1.Decrypt(passcheck);
            if (passcheck == password)
            {
                return check = true;
            }
            else
            {
                return check;
            }

            //return check;


        }
    }
}
