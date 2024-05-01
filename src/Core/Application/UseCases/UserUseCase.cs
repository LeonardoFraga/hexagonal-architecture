using Application.DTOs;
using AutoMapper;
using Domain.Repositories;

namespace Application.UseCases
{
    public class UserUseCase : IUserUseCase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserUseCase(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<List<UserDto>> GetUsers()
        {
            var usuarios = await _userRepository.GetUsersAsync();
            return _mapper.Map<List<UserDto>>(usuarios);
        }
    }
}