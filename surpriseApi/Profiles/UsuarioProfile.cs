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
        CreateMap<Usuario, RetornaUsuarioDto>();//.ForMember(usuarioDto => usuarioDto.id_usuario, opt => opt.MapFrom(usuario => usuario.id));
        CreateMap<RetornaUsuarioDto, Usuario>();
        CreateMap<CreateUsuarioDto, RetornaUsuarioDto>();
        CreateMap<Usuario, DadosLoginDto>().ForMember(usuarioDto => usuarioDto.id, opt => opt.MapFrom(usuario => usuario.id));
        CreateMap<DadosLoginDto, RetornoLoginDto>();
    }
}