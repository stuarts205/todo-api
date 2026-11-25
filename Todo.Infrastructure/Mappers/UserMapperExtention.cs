using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Todo.Domain.DomainEntities;
using Todo.Infrastructure.Persistence.Entities;

namespace Todo.Infrastructure.Mappers
{
    public class UserMapperExtention : Profile
    {
        public UserMapperExtention()
        {
            CreateMap<User, UserDomain>().ReverseMap();
        }
    }
}
