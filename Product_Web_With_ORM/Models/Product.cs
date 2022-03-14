using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_Web_With_ORM.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public bool IsSold { get; set; }
    }
}
