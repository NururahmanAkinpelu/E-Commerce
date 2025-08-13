using Application.DTOs;
using Application.Interface.Repositories;
using Application.Interface.Services;
using Domain.Entitties;

namespace Application.Service
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response<UserDto>> Login(UserLoginRequest request)
        {
            var response = new Response<UserDto>();
            var user = await _unitOfWork.User.GetAsync(x => x.Email == request.Email);
            if (user == null || !BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
            {
                response.Success = false;
                response.Message = "Invalid email or password.";
                return response;
            }
            response.Data = new UserDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Address = user.Address,
                IsEmailVerified = user.IsEmailVerified,
                IsPhoneNumberVerified = user.IsPhoneNumberVerified,
                ProfilePictureUrl = user.ProfilePictureUrl,
                Role = user.Role
            };
            response.Success = true;
            response.Message = "Login successfull.";
            return response;
        }

        public async Task<Response<UserDto>> Register(UserRequest request)
        {
            var response = new Response<UserDto>();
            var exist = await _unitOfWork.User.ExistsAsync(x => x.Email == request.Email);
            if (exist)
            {
                response.Success = false;
                response.Message = "User already exists.";
                return response;
            }
            var user = new User
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password),
                PhoneNumber = request.PhoneNumber,
                Address = request.Address,
                IsEmailVerified = false,
                IsPhoneNumberVerified = false,
                Role = "User", 
            };
            await _unitOfWork.User.AddAsync(user);
            response.Data = new UserDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Address = user.Address,
                IsEmailVerified = user.IsEmailVerified,
                IsPhoneNumberVerified = user.IsPhoneNumberVerified,
                ProfilePictureUrl = user.ProfilePictureUrl,
                Role = user.Role
            };
            response.Success = true;
            response.Message = "User registered successfully.";
            return response;
        }
    }
}
