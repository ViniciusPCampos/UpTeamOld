using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPTEAM.AutoMapper.Parses;
using UPTEAM.AutoMapper.Parses.Interfaces;
using UPTEAM.Infra.CrossCutting;

namespace UPTEAM.IoC
{
    public class DependenceResolver
    {
        public static void Resolver(IKernel kernel)
        {
            DependencyRegister.Resolver(kernel);

            kernel.Bind<ITbUsuarioToUsuarioModelParse>().To<TbUsuarioToUsuarioModelParse>();

        }
    }
}
