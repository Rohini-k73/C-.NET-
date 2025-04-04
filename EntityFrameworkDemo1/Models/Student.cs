using System;
using System.Collections.Generic;

namespace EntityFrameworkDemo1.Models
{
    public partial class Student
    {
        public int Sid { get; set; }
        public string? Sname { get; set; }
        public double? Spercentage { get; set; }
        public string? Slocation { get; set; }
    }
}
