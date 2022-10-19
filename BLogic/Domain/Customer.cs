#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace BLogic.Domain
{
    public class Customer:Identity
    {
      [Required, StringLength(90)]
      public string UserName { get; set; }
      [Required]
      public string Email { get; set; }
      [Required]
      public string Password { get; set; }
      public virtual ICollection<Order> Orders { get; set; }

    }
} 

