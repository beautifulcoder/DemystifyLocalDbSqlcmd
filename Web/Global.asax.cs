using System;
using System.Data.Entity;
using System.Web;
using System.Web.Routing;
using DemystifyLocalDbSqlcmd.Models.Contexts;

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
