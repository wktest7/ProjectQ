﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectQ.Core.Domain
{
    public class Vehicle
    {
        public string Brand { get; protected set; }
        public string Name { get; protected set; }
        public int Seats { get; protected set; }
    }
}
