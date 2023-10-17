using surpriseApi.Data.Dtos.nivel;
using surpriseApi.Models;
using System.ComponentModel.DataAnnotations;

namespace surpriseApi.Data.Dtos.usuario;

public class RetornaUsuarioDto
{
    public int id { get; set; }
    public string nome { get; set; }
    public string? email { get; set; }
    //public virtual Token token { get; set; }
    //public List<RetornaNivelDto> RetornaNivelDto { get; set; }
}
