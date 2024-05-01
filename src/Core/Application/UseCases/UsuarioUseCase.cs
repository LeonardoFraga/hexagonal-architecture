using Application.DTOs;
using AutoMapper;
using Domain.Repositories;

namespace Application.UseCases
{
    public class UsuarioUseCase : IUsuarioUseCase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public UsuarioUseCase(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        public async Task<List<UsuarioDto>> BuscarUsuariosAsync()
        {
            var usuarios = await _usuarioRepository.BuscarUsuariosAsync();
            return _mapper.Map<List<UsuarioDto>>(usuarios);
        }
    }
}