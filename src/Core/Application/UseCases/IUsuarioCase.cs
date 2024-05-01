using Application.DTOs;
using Domain.Entities;

namespace Application.UseCases
{
    public interface IUsuarioUseCase
    {
        Task<List<UsuarioDto>> BuscarUsuariosAsync();
    }
}