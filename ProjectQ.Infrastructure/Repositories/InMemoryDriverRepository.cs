using ProjectQ.Core.Domain;
using ProjectQ.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectQ.Infrastructure.Repositories
{
    public class InMemoryDriverRepository : IDriverRepository
    {

        private static ISet<Driver> _drivers = new HashSet<Driver>
        {
            //new User("user1@gmail.com", "user1", "secret", "salt"),
            //new User("user2@gmail.com", "user2", "secret", "salt"),
            //new User("user3@gmail.com", "user3", "secret", "salt")
        };

        public void Add(Driver driver)
        {
            _drivers.Add(driver);
        }

        public Driver Get(Guid userId)
        {
            return _drivers.Single(x => x.UserId == userId);
        }

        public IEnumerable<Driver> GetAll()
        {
            return _drivers;
        }

        public void Update(Driver driver)
        {
        
        }
    }
}
