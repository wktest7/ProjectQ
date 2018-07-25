using AutoMapper;
using ProjectQ.Core.Domain;
using ProjectQ.Core.Repositories;
using ProjectQ.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQ.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDTO> GetAsync(string email)
        {
            var user = await _userRepository.GetAsync(email);
            //return new UserDTO
            //{
            //    Id = user.Id,
            //    UserName = user.UserName,
            //    Email = user.Email,
            //    FullName = user.FullName
            //};
            return _mapper.Map<User, UserDTO>(user);
        }

        public async Task RegisterAsync(string email, string username, string password)
        {
            var user = await _userRepository.GetAsync(email);
            if (user != null)
            {
                throw new Exception($"User with email: '{email}'  already exists.");
            }

            var salt = Guid.NewGuid().ToString("N");
            user = new User(email, password, salt, username);
            await _userRepository.AddAsync(user);
        }
    }
}
