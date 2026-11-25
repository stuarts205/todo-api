using System;
using System.Collections.Generic;
using System.Text;
using Todo.Application.Dtos.Request;

namespace Todo.Application.Contracts
{
    public interface IUserService
    {
        Task<bool> CreateUserAsync(CreateUserDto userDto);
    }
}
