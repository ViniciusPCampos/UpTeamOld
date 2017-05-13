using System.Collections.Generic;
using UPTEAM.AutoMapper.Parses.Interfaces;
using static AutoMapper.Mapper;

namespace UPTEAM.AutoMapper.Parses
{
    public class ParseBase<Origem, Destino> : IParse<Origem, Destino> where Origem : class where Destino : class
    {
        public IEnumerable<Origem> Parse(IEnumerable<Destino> objs)
        {
            return Map<IEnumerable<Destino>, IEnumerable<Origem>>(objs);
        }

        public IEnumerable<Destino> Parse(IEnumerable<Origem> objs)
        {
            return Map<IEnumerable<Origem>, IEnumerable<Destino>>(objs);
        }

        public Destino Parse(Origem obj)
        {
            return Map<Origem, Destino>(obj);
        }

        public Origem Parse(Destino obj)
        {
            return Map<Destino, Origem>(obj);
        }
    }
}
