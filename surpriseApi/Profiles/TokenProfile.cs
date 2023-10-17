using AutoMapper;
using surpriseApi.Data.Dtos.token;
using surpriseApi.Models;

namespace surpriseApi.Profiles;

public class TokenProfile : Profile
{
    public TokenProfile()
    {
        CreateMap<Token, RetornaTokenDto>();
        CreateMap<RetornaTokenDto, Token>();
    }
}
