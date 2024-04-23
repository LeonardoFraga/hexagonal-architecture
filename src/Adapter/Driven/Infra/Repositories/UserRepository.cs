using Domain.Entities;
using Domain.Repositories;

namespace Infra.Repositories
{
    public class UserRepository : IUserRepository
    {

        // This should come from the database.
        private static IList<User> _users = new List<User>
        {
            new User(1, "John Doe"),
            new User(2, "Jane Doe"),
        };
        
        public IList<User> GetUsers()
        {
            return _users.ToList();
        }

    }
}