using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Todo.Application.Dtos.Request;
using Todo.Domain.DomainEntities;

namespace Todo.Application.Mappers
{
    public class UserMappingExtention : Profile
    {
        public UserMappingExtention()
        {
            CreateMap<CreateUserDto, UserDomain>()
                .ForMember(dest => dest.PasswordHash, opt => opt.MapFrom(src => src.Password));
        }
    }
}
