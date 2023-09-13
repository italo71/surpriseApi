using System.ComponentModel.DataAnnotations;

namespace surpriseApi.Data.Dtos.usuario;

public class UsuarioParaValidar
{
    public string? login { get; set; }
    [Required(ErrorMessage = "A senha não pode ser nula ou vazia")]
    public string senha { get; set; }
    public string? email { get; set; }
}
