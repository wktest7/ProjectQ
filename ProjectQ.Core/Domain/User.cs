﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectQ.Core.Domain
{
    public class User
    {
        public Guid Id { get; protected set; }
        public string Email { get; protected set; }
        public string Password { get; protected set; }
        public string Salt { get; protected set; }
        public string UserName { get; protected set; }
        public string FullName { get; protected set; }
        public DateTime CreatedAt { get; protected set; }

        protected User()
        {

        }

        public User(string email, string password, string salt, string userName)
        {
            Id = Guid.NewGuid();
            Email = email.ToLowerInvariant();
            Password = password;
            Salt = salt;
            UserName = userName;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
