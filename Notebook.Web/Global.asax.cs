using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;
using Notebook.Web.App_Start;
using Notebook.Web.Util;
using System.Web.Mvc;
using System.Web.Routing;

namespace Notebook.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            MapperConfig.ConfigureMapping();

            // внедрение зависимостей
            NinjectModule module = new DIModule();
            var kernel = new StandardKernel(module);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}
