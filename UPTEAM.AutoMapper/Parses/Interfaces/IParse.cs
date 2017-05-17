using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPTEAM.AutoMapper.Parses.Interfaces
{
    public interface IParse<Origem, Destino>
    {
        Origem Parse(Destino obj);
        Destino Parse(Origem obj);
        IEnumerable<Origem> Parse(IEnumerable<Destino> objs);
        IEnumerable<Destino> Parse(IEnumerable<Origem> objs);
    }
}
