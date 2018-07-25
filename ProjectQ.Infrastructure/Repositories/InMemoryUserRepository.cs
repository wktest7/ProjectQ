﻿using ProjectQ.Core.Domain;
using ProjectQ.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQ.Infrastructure.Repositories
{
    public class InMemoryUserRepository : IUserRepository
    {
        private static ISet<User> _users = new HashSet<User>
        {
            new User("user1@gmail.com", "user1", "secret", "salt"),
            new User("user2@gmail.com", "user2", "secret", "salt"),
            new User("user3@gmail.com", "user3", "secret", "salt")
        };


        public async Task<User> GetAsync(Guid id)
        {
           return await Task.FromResult(_users.Single(x => x.Id == id));
        }

        public async Task<User> GetAsync(string email)
        {
            return await Task.FromResult(_users.SingleOrDefault(x => x.Email == email.ToLowerInvariant()));
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await Task.FromResult(_users);
        }

        public async Task AddAsync(User user)
        {
            _users.Add(user);
            await Task.CompletedTask;
        }

        public async Task RemoveAsync(Guid id)
        {
            var user = await GetAsync(id);
            _users.Remove(user);
            await Task.CompletedTask;
        }

        public async Task UpdateAsync(User user)
        {
            await Task.CompletedTask;
        }
    }
}
