using Domain.Entities;

namespace Application.UseCases
{
    public interface IUserUseCase
    {
        IList<User> GetUsers();
    }
}