using AutoMapper;
using surpriseApi.Data.Dtos.usuario;
using surpriseApi.Models;

namespace surpriseApi.Profiles;

public class UsuarioProfile : Profile
{
    public UsuarioProfile()
    {
        CreateMap<Usuario, CreateUsuarioDto>();
        CreateMap<CreateUsuarioDto, Usuario>();
        CreateMap<Usuario, RetornaUsuarioDto>();
        CreateMap<RetornaUsuarioDto, Usuario>();
        CreateMap<CreateUsuarioDto, RetornaUsuarioDto>();
    }
}
