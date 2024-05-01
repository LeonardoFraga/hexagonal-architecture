using Domain.Entities;
using Domain.Repositories;
using Infra.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _context;

        public UsuarioRepository(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<List<Usuario>> BuscarUsuariosAsync()
        {
            return await _context.Usuarios.ToListAsync();
        }
    }
}