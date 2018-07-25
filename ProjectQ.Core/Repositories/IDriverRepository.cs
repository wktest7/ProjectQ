using ProjectQ.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectQ.Core.Repositories
{
    public interface IDriverRepository
    {
        Driver Get(Guid id);
        IEnumerable<Driver> GetAll();
        void Add(Driver driver);
        void Update(Driver driver);
        
    }
}
