using Domain.Entities;

namespace Domain.Repositories
{
    // TODO: Mudar o nome da interface para portugues
    public interface IUserRepository
    {
        // TODO: Mudar o nome do metodo para portugues
         Task<List<Usuario>> GetUsersAsync();
    }
}