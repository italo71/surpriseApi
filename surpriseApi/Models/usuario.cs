using System.ComponentModel.DataAnnotations;
using BCrypt.Net;
namespace surpriseApi.Models;

public class Usuario
{
    [Key]
    [Required]
    public int id { get; set; }
    [Required]
    public string login { get; set; }
    [Required]
    public string senha { get; set; }
    [Required]
    public string nome { get; set; }
    
    public string? email { get; set; }

    public virtual Token token { get; set; }

    public virtual List<Nivel> nivel { get; set; }

    public void DefinirSenha(string senha)
    {
        this.senha = BCrypt.Net.BCrypt.HashPassword(senha, BCrypt.Net.BCrypt.GenerateSalt());
    }

    // Método para verificar a senha durante a autenticação
    public bool VerificarSenha(string senha)
    {
        return BCrypt.Net.BCrypt.Verify(senha, this.senha);
    }
}
