using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Project5A8A9
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["accessrequest"] = 0;
            Application["ApplicationStartTime"] = DateTime.Now.ToString();
            //Application[""]
        }
        void Application_BeginRequest(object sender, EventArgs e)
        {
            Application.Lock();
            Application["accessrequest"] = (int)Application["accessrequest"] + 1;
            Application.UnLock();
        }
        void Application_End(object sender, EventArgs e)
        {
            // Response.Write("<hr />This page was last accessed at " + DateTime.Now.ToString());
            Application.Lock();
            Application["accessrequest"] = (int)Application["accessrequest"] - 1;
            Application.UnLock();
        }
        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started

        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.

        }
    }
}