using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp7
{
    public partial class Car
    {
        public Car()
        {
            Sales = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public int MarkId { get; set; }
        public string Engine { get; set; }

        public virtual Mark Mark { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
