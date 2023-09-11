using AutoMapper;
using surpriseApi.Data.Dtos;
using surpriseApi.Models;

namespace surpriseApi.Profiles;

public class UsuarioProfile : Profile
{
    public UsuarioProfile()
    {
        CreateMap<usuario, CreateUsuarioDto>();
        CreateMap<CreateUsuarioDto, usuario>();
    }
}
