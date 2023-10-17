using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace surpriseApi.Models;

public class Token
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "Identificador do usuário não pode ser nulo ou vazio")]
    [ForeignKey(nameof(Usuarioid))]
    public int Usuarioid { get; set; }
    public string token { get; set; }
}
