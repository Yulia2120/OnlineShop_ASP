#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLogic.Domain
{
    public class Company : Identity
    {
        [StringLength(255)]
        public string CompanyName { get; set; }
        [StringLength(1000)]
        public string Contact { get; set; }



    }
}
