using Domain.Entities;
using Domain.Repositories;
using Infra.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<List<Usuario>> GetUsersAsync()
        {
            return await _context.Usuarios.ToListAsync();
        }
    }
}