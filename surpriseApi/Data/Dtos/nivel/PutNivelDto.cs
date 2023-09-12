using System.ComponentModel.DataAnnotations;

namespace surpriseApi.Data.Dtos.nivel;

public class PutNivelDto
{
    [Required(ErrorMessage = "Informe o identificador do Nivel")]
    public int id { get; set; }
    [Required(ErrorMessage = "Nivel Atual requerido")]
    public int nivel_atual { get; set; }
    public string? obs { get; set; }
}
