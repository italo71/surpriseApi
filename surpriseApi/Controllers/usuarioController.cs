using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using surpriseApi.Data;
using surpriseApi.Data.Dtos;
using surpriseApi.Models;

namespace surpriseApi.Controllers;

[ApiController]
[Route("[Controller]")]
public class usuarioController : ControllerBase
{
    private surpriseContext _context;
    private IMapper _mapper;

    public usuarioController(surpriseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult cadastrarUsuario([FromBody] CreateUsuarioDto usuario)
    {
        usuario usu = _mapper.Map<usuario>(usuario);
        _context.usuarios.Add(usu);
        _context.SaveChanges();
        return CreatedAtAction(nameof(obterUsuario), new { id = usu.id }, usu);
    }

    [HttpGet("{id}")]
    public IActionResult obterUsuario([FromQuery] int id)
    {
        var usuario = _context.usuarios.FirstOrDefault(usuario => usuario.id == id);
        if(usuario == null) return NotFound();
        return Ok(usuario);
    }

}
