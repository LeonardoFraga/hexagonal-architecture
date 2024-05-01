using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappers
{
    public class UsuarioProfile: Profile
    {
        public UsuarioProfile()
        {
            CreateMap<Usuario, UserDto>().ReverseMap();
        }
    }
}