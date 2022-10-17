using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLogic.Domain
{
    public class Product : Identity
    {
        public string ProductName { get; set; } = string.Empty;
        public string ProductDescription { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public Company Company { get; set; }
        public ProductCategory ProductCategory  { get; set; }

    }
}
