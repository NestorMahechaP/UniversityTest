using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace UniversityTest
{
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			UnityConfig.RegisterComponents();
			DashboardConfig.RegisterService(RouteTable.Routes);
			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}
	}
}
