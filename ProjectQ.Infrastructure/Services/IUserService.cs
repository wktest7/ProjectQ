using ProjectQ.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectQ.Infrastructure.Services
{
    public interface IUserService
    {
        UserDTO Get(string email);


        void Register(string email, string username, string password);
    }
}
