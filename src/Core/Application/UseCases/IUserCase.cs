using Application.DTOs;
using Domain.Entities;

namespace Application.UseCases
{
    public interface IUserUseCase
    {
        Task<List<UserDto>> GetUsers();
    }
}