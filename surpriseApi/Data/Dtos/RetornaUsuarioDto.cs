using System.ComponentModel.DataAnnotations;

namespace surpriseApi.Data.Dtos;

public class RetornaUsuarioDto
{
    public string nome { get; set; }
    public string? email { get; set; }
}
