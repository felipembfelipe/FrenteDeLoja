using AutoMapper;
using FrenteDeLoja.Models.DTO;
using FrenteDeLoja.Models;

namespace FrenteDeLoja.Infra.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();

            CreateMap<TipoUsuario, TipoUsuarioDTO>().ReverseMap();
        }
    }
}
