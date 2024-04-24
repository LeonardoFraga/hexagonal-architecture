using Domain.Entities;
using Domain.Repositories;

namespace Infra.Repositories
{
    public class UserRepository : IUserRepository
    {

        // This should come from the database.
        private static IList<Usuario> _users = new List<Usuario>
        {
            new Usuario(1, "John Doe", "john.d@test.com", "12345678", new Domain.ValueObjects.CPF("12345678901"), new Domain.ValueObjects.Endereco("Rua 1", "Casa 1", "Bairro 1", "Cidade 1", "Estado 1", "12345678")),
            new Usuario(2, "Jane Doe", "jane.d@test.com", "12345678", new Domain.ValueObjects.CPF("12345678901"), new Domain.ValueObjects.Endereco("Rua 2", "Casa 2", "Bairro 2", "Cidade 2", "Estado 2", "12345678")),
        };
        
        public IList<Usuario> GetUsers()
        {
            return _users.ToList();
        }

    }
}