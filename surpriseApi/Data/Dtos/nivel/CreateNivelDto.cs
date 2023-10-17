using System.ComponentModel.DataAnnotations;

namespace surpriseApi.Data.Dtos.nivel;

public class CreateNivelDto
{
    [Required(ErrorMessage = "Nivel Atual requerido")]
    public int nivel_atual { get; set; }
    public string? obs { get; set; }
    [Required(ErrorMessage = "Informe o identificador do usuário")]
    public int Usuarioid { get; set; }
}
