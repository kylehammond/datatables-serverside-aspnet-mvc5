using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;

namespace DataTableTest.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
            // DataTables.AspNet registration with default options.
            DataTables.AspNet.Mvc5.Configuration.RegisterDataTables();

            UnityConfig.RegisterTypes(new UnityContainer());
        }
    }
}