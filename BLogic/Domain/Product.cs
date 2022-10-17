#pragma warning disable CS8618 
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLogic.Domain
{
    public class Product : Identity
    {
        [Required, StringLength(155)]
        public string ProductName { get; set; }
        public string ImgUrl { get; set; }
        public string ProductDescription { get; set; } 
        public decimal Price { get; set; }
        [Required]
        public int ProductCategoryId { get; set; }
        [Required]
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }
        [ForeignKey("ProductCategoryId")]
        public virtual ProductCategory ProductCategory  { get; set; }

    }
}
