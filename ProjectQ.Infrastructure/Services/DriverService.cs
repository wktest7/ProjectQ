using System;
using System.Collections.Generic;
using System.Text;
using ProjectQ.Core.Repositories;
using ProjectQ.Infrastructure.DTO;

namespace ProjectQ.Infrastructure.Services
{
    public class DriverService : IDriverService
    {
        private readonly IDriverRepository _driverRepository;

        public DriverService(IDriverRepository driverRepository)
        {
            _driverRepository = driverRepository;
        }

        public DriverDTO Get(Guid userId)
        {
            var driver = _driverRepository.Get(userId);

            return new DriverDTO
            {
               // UserId = driver.UserId,
                
            };


        }
    }
}
