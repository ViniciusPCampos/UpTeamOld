using AutoMapper;
using UPTEAM.Domain.Entities;
using UPTEAM.Models;

namespace UPTEAM.AutoMapper.MappingProfile
{
    public class TbProjetoMappingProfile : Profile
    {
        public TbProjetoMappingProfile()
        {
            CreateMap<tb_projeto, ProjetoModel>()
                .ForMember(x => x.ID, x => x.MapFrom(y => y.idt_projeto))
                .ForMember(x => x.NomeProjeto, x => x.MapFrom(y => y.nme_projeto))
                .ForMember(x => x.DescricaoProjeto, x => x.MapFrom(y => y.dsc_projeto))
                .ForMember(x => x.DataInicioProjeto, x => x.MapFrom(y => y.dta_inicio))
                .ForMember(x => x.DataTerminoProjeto, x => x.MapFrom(y => y.dta_termino))
                .ForMember(x => x.EquipeProjeto, x => x.MapFrom(y => y.idt_equipe));
        }
            
    }
}
