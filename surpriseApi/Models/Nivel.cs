using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace surpriseApi.Models;

public class Nivel
{
    [Key]
    [Required]
    public int id { get; set; }
    [Required(ErrorMessage = "Nivel Atual requerido")]
    public int nivel_atual { get; set; }
    public string? obs { get; set; }
    [Required(ErrorMessage = "Informe o identificador do usuário")]
    //[ForeignKey(nameof(Usuarioid))]
    public int Usuarioid { get; set; }
}
