#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace BLogic.Domain
{
    public class Company :Identity
    {
        [StringLength(255)]
        public string CompanyName { get; set; }
        [StringLength(1000)]
        public string Contact { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}
