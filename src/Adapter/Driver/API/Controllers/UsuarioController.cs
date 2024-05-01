using Application.DTOs;
using Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioUseCase _usuarioUseCase;
    private readonly ILogger<UsuarioController> _logger;

    public UsuarioController(ILogger<UsuarioController> logger, IUsuarioUseCase usuarioUseCase)
    {
        _logger = logger;
        _usuarioUseCase = usuarioUseCase;
    }

    [HttpGet]
    public async Task<ActionResult<List<UsuarioDto>>> Get()
    {
        var usuarios = await _usuarioUseCase.BuscarUsuariosAsync();
        return Ok(usuarios);
    }
}
