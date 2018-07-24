using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectQ.Core.Domain
{
    public class Node
    {
        public string Address { get; protected set; }
        public double Longitude { get; protected set; }
        public double Latitude { get; set; }
    }
}
