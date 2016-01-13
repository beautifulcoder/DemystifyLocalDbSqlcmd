using DemystifyLocalDbSqlcmd.Models.Contexts;
using System;
using System.Data.Entity;
using System.Web;
using System.Web.Routing;

namespace DemystifyLocalDbSqlcmd
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Database.SetInitializer(new ApplicationDatabaseInitialize());
        }
    }
}
