﻿using System;
using System.Collections.Generic;

namespace EntityFrameworkDemo1.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Salary { get; set; }
        public string Designation { get; set; } = null!;
    }
}
