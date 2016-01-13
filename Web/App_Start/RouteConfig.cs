using System.Web.Mvc;
using System.Web.Routing;

namespace DemystifyLocalDbSqlcmd
{
    internal static class RouteConfig
    {
        internal static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute("Default", "{controller}/{action}", new { controller = "Home", action = "Index" });
        }
    }
}
