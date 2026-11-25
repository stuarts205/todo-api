using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Todo.Domain.DomainEntities;

namespace Todo.Infrastructure.Mappers
{
    public class UserMapperExtention : Profile
    {
        public UserMapperExtention()
        {
            CreateMap<UserMapperExtention, UserDomain>();
        }
    }
}
