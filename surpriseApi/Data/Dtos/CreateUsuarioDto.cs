using System.ComponentModel.DataAnnotations;

namespace surpriseApi.Data.Dtos;

public class CreateUsuarioDto
{
    [Required]
    public string login { get; set; }
    [Required]
    public string senha { get; set; }
    [Required]
    public string nome { get; set; }
    public string email { get; set; }
}
