using Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
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
    public IActionResult Get()
    {
        return Ok(_userUseCase.GetUsers());
    }
}
