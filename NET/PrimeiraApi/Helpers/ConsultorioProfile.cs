using AutoMapper;
using Org.BouncyCastle.Crypto.Agreement.Srp;
using PrimeiraApi.Models.DTOs;
using PrimeiraApi.Models.Entities;


// usado para fazer o mapeamento global
namespace PrimeiraApi.Helpers
{
    public class ConsultorioProfile : Profile
    {
        public ConsultorioProfile()
        {
            CreateMap<Paciente, PacienteDetalhesDTO>();
            CreateMap<Consulta, ConsultaDTO>()
                .ForMember(dest => dest.Especialidade, opt => opt.MapFrom(src => src.Especialidade.Nome))
                .ForMember(dest => dest.Profissional, opt => opt.MapFrom(src => src.Profissional.Nome));
        }
    }
}
