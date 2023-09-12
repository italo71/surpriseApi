using System.ComponentModel.DataAnnotations;

namespace surpriseApi.Data.Dtos.usuario;

public class RetornaUsuarioDto
{
    public string nome { get; set; }
    public string? email { get; set; }
}
