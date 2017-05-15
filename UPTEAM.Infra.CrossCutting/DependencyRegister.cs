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
        }
        public static void ResolverRepository(IKernel kernel)
        {
            kernel.Bind<IUsuarioRepository>().To<UsuarioRepository>();
        }
        public static void ResolverOthers(IKernel kernel)
        {
            kernel.Bind<ICryptographyHelper>().To<CryptographyHelper>();          
        }
    }
}
