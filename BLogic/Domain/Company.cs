using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLogic.Domain
{
    public class Company :Identity
    {
        public string CompanyName { get; set; }= string.Empty;
        public string Contact { get; set; }= string.Empty;
        public List<Product> Products { get; set; }

    }
}
