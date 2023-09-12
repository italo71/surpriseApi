using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using surpriseApi.Data;
using surpriseApi.Data.Dtos.usuario;
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

    [HttpPost("cadastro")]
    public IActionResult cadastrarUsuario([FromBody] CreateUsuarioDto usuario)
    {
        Usuario usu = _mapper.Map<Usuario>(usuario);
        usu.DefinirSenha(usu.senha);
        var usuCad = _context.Usuarios.FirstOrDefault(usuCadastrado => usuCadastrado.login == usu.login);
        if (usuCad == null)
        {
            _context.Usuarios.Add(usu);
            _context.SaveChanges();
            return CreatedAtAction(nameof(obterUsuario), new { id = usu.id }, usu);
        }
        else return Conflict(new Retorno { status = "erro", message = "Usuario ja cadastrado" });
    }

    [HttpPost("login")]
    public IActionResult obterUsuario([FromBody] UsuarioParaValidar usu)
    {
        var usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.login == usu.login);
        if (usuario == null) return NotFound();
        Usuario usuarioSelect = _mapper.Map<Usuario>(usuario);
        if (usuarioSelect.VerificarSenha(usu.senha))
            return Ok(_mapper.Map<RetornaUsuarioDto>(usuario));
        else return Unauthorized();
    }

}
