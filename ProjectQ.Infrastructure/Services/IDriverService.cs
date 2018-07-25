using ProjectQ.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectQ.Infrastructure.Services
{
    public interface IDriverService
    {
        DriverDTO Get(Guid userId);


    }
}
