using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace surpriseApi.Data.Dtos;

[Index(nameof(login), IsUnique = true)]
public class CreateUsuarioDto
{
    [Required(ErrorMessage = "O login não pode ser vazio")]
    public string login { get; set; }
    [Required (ErrorMessage = "A senha não pode ser vazio")]
    public string senha { get; set; }
    [Required(ErrorMessage = "O nome não pode ser vazio")]
    public string nome { get; set; }
    public string? email { get; set; }
}
