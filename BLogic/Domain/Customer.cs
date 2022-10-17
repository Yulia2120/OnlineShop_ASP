using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLogic.Domain
{
    public class Customer:Identity
    {
      public string UserName { get; set; }=string.Empty;
      public string Email { get; set; }=string.Empty;
      public string Password { get; set; }=string.Empty;
      public List<Order> Orders { get; set; }

    }
} 

