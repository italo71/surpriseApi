using System.ComponentModel.DataAnnotations;

namespace surpriseApi.Data.Dtos.usuario;

public class RetornaUsuarioDto
{
    public int id { get; set; }
    public string nome { get; set; }
    public string? email { get; set; }
}
