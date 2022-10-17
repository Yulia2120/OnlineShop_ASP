#pragma warning disable CS8618 
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLogic.Domain
{
    public class Order:Identity
    {
       [Required]
       public int CustomerId { get; set; }
       public DateTime DateTime { get; set; }
       [ForeignKey("CustomerId")]
       public virtual Customer Customer { get; set; }

    }
}
