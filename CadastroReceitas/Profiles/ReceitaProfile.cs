using AutoMapper;
using CadastroReceitas.Data.DTos;
using CadastroReceitas.Models;

namespace CadastroReceitas.Profiles
{
    public class ReceitaProfile : Profile
    {

        public ReceitaProfile()
        {
            CreateMap<CreateReceitaDto, ReceitaModel>();
            CreateMap<ReceitaModel, ReadReceitaDto>();
            CreateMap<UpdateReceitaDto, ReceitaModel>();

        }
    }
}
