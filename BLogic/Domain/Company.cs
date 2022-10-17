#pragma warning disable CS8618 
using System.ComponentModel.DataAnnotations;

namespace BLogic.Domain
{
    public class Company :Identity
    {
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Contact { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}
