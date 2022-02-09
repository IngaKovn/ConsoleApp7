using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp7
{
    public partial class Customer
    {
        public Customer()
        {
            Sales = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
