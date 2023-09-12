using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using surpriseApi.Data;
using surpriseApi.Data.Dtos.nivel;
using surpriseApi.Models;

namespace surpriseApi.Controllers;

[ApiController]
[Route("[Controller]")]
public class NivelController : ControllerBase
{
    private IMapper _mapper;
    private surpriseContext _context;

    public NivelController(surpriseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost("cadastro")]
    public IActionResult cadastrarNivel([FromBody] CreateNivelDto nivel)
    {
        Nivel nive = _mapper.Map<Nivel>(nivel);
        try
        {
            var usu = _context.Usuarios.FirstOrDefault(x => x.id == nive.id_usuario);
            if (usu == null)
            {
                return BadRequest(new Retorno { code = 404, status = "erro", message = "Usuário não encontrado"});
            }
            _context.Niveis.Add(nive);
            _context.SaveChanges();
            return CreatedAtAction(nameof(obterNivel), new { id_usuario = nive }, nive);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("obter")]
    public IActionResult obterNivel([FromBody] ObterNivelDto id_usu)
    {
        //var nivelBusca = _context.Niveis.FirstOrDefault(niv => id_usuario.id_usuario == niv.id_usuario);
        var nivelBusca = _context.Niveis.Where(nive => nive.id_usuario == id_usu.id_usuario).OrderByDescending(n => n.id).FirstOrDefault();
        if (nivelBusca == null) return NotFound();
        Nivel nivel = _mapper.Map<Nivel>(nivelBusca);
        return Ok(nivel);
    }
}
