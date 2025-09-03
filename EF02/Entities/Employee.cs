﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entities
{
    internal class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }
        public double? Salary { get; set; }
        public string Address { get; set; }

    }
}
