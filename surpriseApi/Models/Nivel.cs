using System.ComponentModel.DataAnnotations;

namespace surpriseApi.Models;

public class Nivel
{
    [Key]
    [Required]
    public int id { get; set; }
    [Required(ErrorMessage = "Informe o identificador do usuário")]
    public int id_usuario { get; set; }
    [Required(ErrorMessage = "Nivel Atual requerido")]
    public int nivel_atual { get; set; }
    public string? obs { get; set; }

}
