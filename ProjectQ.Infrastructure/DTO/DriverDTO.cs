using ProjectQ.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectQ.Infrastructure.DTO
{
    public class DriverDTO
    {
        public Guid UserId { get; protected set; }
        public Vehicle Vehicle { get; protected set; }
        public IEnumerable<Route> Routes { get; protected set; }
        public IEnumerable<DailyRoute> DailyRoutes { get; protected set; }
    }

}
