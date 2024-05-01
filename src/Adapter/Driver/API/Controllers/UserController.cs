using Application.DTOs;
using Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserUseCase _userUseCase;
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger, IUserUseCase userUseCase)
    {
        _logger = logger;
        _userUseCase = userUseCase;
    }

    [HttpGet]
    public async Task<ActionResult<List<UserDto>>> Get()
    {
        var usuarios = await _userUseCase.GetUsers();
        return Ok(usuarios);
    }
}
