using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.Services
{
    public interface IUserService
    {
        Task<Response<UserDto>> Register(UserRequest request);
        Task<Response<UserDto>> Login(UserLoginRequest request);
    }
}
