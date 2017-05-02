using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SimpleInjector;
using SimpleInjector.Diagnostics;
using System;
using UPTEAM.Domain.Interfaces;
using UPTEAM.Infra.CrossCutting.Identity.Configuration;
using UPTEAM.Infra.CrossCutting.Identity.Context;
using UPTEAM.Infra.CrossCutting.Identity.Model;
using UPTEAM.Infra.Data.Repositories;

namespace UPTEAM.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            container.Register<IDisposable, ApplicationDbContext>(Lifestyle.Scoped);
            container.Register<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(new ApplicationDbContext()), Lifestyle.Scoped);
            container.Register<IRoleStore<IdentityRole, string>>(() => new RoleStore<IdentityRole>(), Lifestyle.Scoped);
            container.Register<ApplicationRoleManager>(Lifestyle.Scoped);
            container.Register<ApplicationUserManager>(Lifestyle.Scoped);
            RegisterDisposableTransient<ApplicationSignInManager>(container);
            container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Scoped);
        }
        public static void RegisterDisposableTransient<TImplementation>(Container c)
        where TImplementation : class, IDisposable
        {
            var scoped = Lifestyle.Scoped;
            var r = Lifestyle.Transient.CreateRegistration<TImplementation>(c);
            r.SuppressDiagnosticWarning(DiagnosticType.DisposableTransientComponent, "ignore");
            c.RegisterInitializer<TImplementation>(o => scoped.RegisterForDisposal(c, o));
        }
    }
}
