using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Prac9__Materials_
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {

        }

        void Application_Error(object sender, Exception e)
        {
            Application.Lock();
            Application["ErrorMsg"] += Server.GetLastError().Message;
            Application.UnLock();
        }
    }
}