using System;
using System.Collections.Generic;

namespace EntityFrameworkDemo1.Models
{
    public partial class General
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public int Age { get; set; }
    }
}
