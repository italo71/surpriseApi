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
            var usu = _context.Usuarios.FirstOrDefault(x => x.id == nive.Usuarioid);
            if (usu == null)
            {
                return BadRequest(new Retorno { code = 404, status = "erro", message = "Usuário não encontrado" });
            }
            _context.Niveis.Add(nive);
            _context.SaveChanges();
            return CreatedAtAction(nameof(obterNivel), new { Usuarioid = nive }, nive);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("obter")]
    public IActionResult obterNivel([FromBody] ObterNivelDto id_usu)
    {
        var nivelBusca = _context.Niveis.Where(nive => nive.Usuarioid == id_usu.Usuarioid).OrderByDescending(n => n.id).FirstOrDefault();
        if (nivelBusca == null) return NotFound(new Retorno { code = 404, status = "erro", message = "Nivel não encontrado" });
        RetornaNivelDto nivel = _mapper.Map<RetornaNivelDto>(nivelBusca);
        return Ok(nivel);
    }
    [HttpPost("obterall")]
    public IActionResult obterTodosNiveis([FromBody] ObterNivelDto id_usu)
    {
        try
        {
            List<Nivel> nivelBusca = _context.Niveis.Where(nive => nive.Usuarioid == id_usu.Usuarioid).ToList();
            if (nivelBusca == null || nivelBusca.Count <= 0) return NotFound(new Retorno { code = 404, status = "erro", message = "Nivel não encontrado" });
            else
            {
                List<RetornaNivelDto> dadosRetorno = _mapper.Map<List<RetornaNivelDto>>(nivelBusca);
                return Ok(dadosRetorno);
            }
        }
        catch { return BadRequest(); }
    }

    [HttpPut("atualizar")]
    public IActionResult atualizarNivel([FromBody] PutNivelDto putNivel)
    {
        var nivelFinded = _context.Niveis.FirstOrDefault(n => n.id == putNivel.id);
        if (nivelFinded == null) return NotFound(new Retorno { code = 404, status = "erro", message = "Nivel não encontrado" });
        _mapper.Map(putNivel, nivelFinded);
        _context.SaveChanges();
        return NoContent();
    }
}
