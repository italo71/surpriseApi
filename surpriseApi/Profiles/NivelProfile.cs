namespace surpriseApi.Profiles;
using AutoMapper;
using surpriseApi.Data.Dtos.nivel;
using surpriseApi.Models;

public class NivelProfile : Profile
{
    public NivelProfile()
    {
        CreateMap<Nivel, CreateNivelDto>();
        CreateMap<CreateNivelDto, Nivel>();
        CreateMap<Nivel, RetornaNivelDto>();
    }

}
