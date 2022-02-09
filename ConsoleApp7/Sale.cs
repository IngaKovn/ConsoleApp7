using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp7
{
    public partial class Sale
    {
        public int Id { get; set; }
        public DateTime DateSale { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public int WorkerId { get; set; }

        public virtual Car Car { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
