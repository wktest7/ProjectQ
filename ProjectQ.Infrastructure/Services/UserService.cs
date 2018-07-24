﻿using ProjectQ.Core.Domain;
using ProjectQ.Core.Repositories;
using ProjectQ.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectQ.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserDTO Get(string email)
        {
            var user = _userRepository.Get(email);
            return new UserDTO
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                FullName = user.FullName
            };
        }

        public void Register(string email, string username, string password)
        {
            var user = _userRepository.Get(email);
            if (user != null)
            {
                throw new Exception($"User with email: '{email}'  already exists.");
            }

            var salt = Guid.NewGuid().ToString("N");
            user = new User(email, username, password, salt);
            _userRepository.Add(user);
        }
    }
}
