﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectQ.Infrastructure.Commands.Users
{
    public class CreateUser : ICommand
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }

    }
}
