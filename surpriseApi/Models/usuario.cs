using System.ComponentModel.DataAnnotations;

namespace surpriseApi.Models;

public class usuario
{
    [Required]
    [Key]
    public int id { get; set; }
    [Required]
    public string login { get; set; }
    [Required]
    public string senha { get; set; }
    [Required]
    public string nome { get; set; }
    public string email { get; set; }
}
