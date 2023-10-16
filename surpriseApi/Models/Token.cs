using System.ComponentModel.DataAnnotations;

namespace surpriseApi.Models;

public class Token
{
    [Key]
    [Required(ErrorMessage = "Identificador do usuário não pode ser nulo ou vazio")]
    public int id_usuario { get; set; }
    public string token { get; set; }
}
