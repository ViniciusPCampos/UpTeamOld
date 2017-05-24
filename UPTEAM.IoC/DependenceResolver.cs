﻿using Ninject;
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
            kernel.Bind<IUsuarioModelToTbUsuarioParse>().To<UsuarioModelToTbUsuarioParse>();
            kernel.Bind<ITbTarefaToTarefaModelParse>().To<TbTarefaToTarefaModelParse>();
            kernel.Bind<ITarefaModelToTbTarefaParse>().To<TarefaModelToTbTarefaParse>();
            kernel.Bind<ITbMarcoToMarcoModelParse>().To<TbMarcoToMarcoModelParse>();
            kernel.Bind<IMarcoModelToTbMarcoParse>().To<MarcoModelToTbMarcoParse>();
        }
    }
}
