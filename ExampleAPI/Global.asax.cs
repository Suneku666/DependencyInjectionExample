using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ExampleCommon.IoC;

namespace ExampleAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            IoCConfig.RegisterStartupRequirements(
                IoCContainerFactory.GetContainer());
            GlobalConfiguration.Configuration.DependencyResolver = 
                new Unity.WebApi.UnityDependencyResolver(
                IoCContainerFactory.GetContainer());
        }
    }
}
