using AutoMapper;
using CadastroReceitas.Data.DTos;
using CadastroReceitas.Models;

namespace CadastroReceitas.Profiles
{
    public class DespesaProfile : Profile
    {

        public DespesaProfile()
        {
            CreateMap<CreateDespesaDto, DespesaModel>();
            CreateMap<DespesaModel, ReadDespesaDto>();
            CreateMap<UpdateDespesaDto, DespesaModel>();

        }
    }
}
