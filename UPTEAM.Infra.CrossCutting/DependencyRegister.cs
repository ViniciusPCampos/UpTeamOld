using Ninject;
using UPTEAM.ApplicationServices;
using UPTEAM.ApplicationServices.Helpers.Criptography;
using UPTEAM.Domain.RepositoryInterfaces;
using UPTEAM.Domain.ServiceInterfaces;
using UPTEAM.Infra.Data.Context;
using UPTEAM.Infra.Data.Repositories;

namespace UPTEAM.Infra.CrossCutting
{
    public class DependencyRegister
    {
        public static void Resolver(IKernel kernel)
        {
            ResolverContext(kernel);
            ResolverService(kernel);
            ResolverRepository(kernel);
            ResolverOthers(kernel);
        }
        public static void ResolverContext(IKernel kernel)
        {
            kernel.Bind<UpTeamContext>().To<UpTeamContext>();
        }
        public static void ResolverService(IKernel kernel)
        {
            kernel.Bind<IUsuarioService>().To<UsuarioService>();
            kernel.Bind<ITarefaService>().To<TarefaService>();
            kernel.Bind<IMarcoService>().To<MarcoService>();
        }
        public static void ResolverRepository(IKernel kernel)
        {
            kernel.Bind<IUsuarioRepository>().To<UsuarioRepository>();
            kernel.Bind<ITarefaRepository>().To<TarefaRepository>();
            kernel.Bind<IMarcoRepository>().To<MarcoRepository>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
        }
        public static void ResolverOthers(IKernel kernel)
        {
            kernel.Bind<ICryptographyHelper>().To<CryptographyHelper>();       
        }
    }
}
