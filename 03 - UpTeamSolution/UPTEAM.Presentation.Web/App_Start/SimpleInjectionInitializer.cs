using System.Web;
using Microsoft.Owin;
using SimpleInjector;
using SimpleInjector.Advanced;
using SimpleInjector.Integration.Web;
using UPTEAM.Infra.CrossCutting.IoC;
using UPTEAM.Presentation.Web.App_Start;
using WebActivatorEx;
using System.Reflection;
using System.Web.Mvc;
using SimpleInjector.Integration.Web.Mvc;

[assembly: PostApplicationStartMethod(typeof(SimpleInjectionInitializer), "Initilize")]

namespace UPTEAM.Presentation.Web.App_Start
{
    public class SimpleInjectionInitializer
    {
        public static void Initilize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            InitializeContainer(container);

            container.Register(() =>
            {
                if (HttpContext.Current != null && HttpContext.Current.Items["owin.Environment"] == null && container.IsVerifying())
                {
                    return new OwinContext().Authentication;
                }
                return HttpContext.Current.GetOwinContext().Authentication;
            });

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }

        private static void InitializeContainer(Container container)
        {
            BootStrapper.RegisterServices(container);
        }
    }
}