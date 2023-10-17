using surpriseApi.Models;

namespace surpriseApi.Data.Dtos.usuario;

public class DadosLoginDto
{
    public int id { get; set; }
    public Token token { get; set; }
    public List<Nivel> nivel { get; set; }
}
