using surpriseApi.Data.Dtos.nivel;
using surpriseApi.Data.Dtos.token;
using surpriseApi.Models;

namespace surpriseApi.Data.Dtos.usuario;

public class RetornoLoginDto
{
    public RetornaTokenDto token { get; set; }
    public List<RetornaNivelDto> nivels { get; set; }
}
