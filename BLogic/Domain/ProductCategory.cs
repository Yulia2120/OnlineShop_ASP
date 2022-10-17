#pragma warning disable CS8618 
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLogic.Domain
{
    public class ProductCategory:Identity
    {
        [StringLength(155)]
        public string CategoryName { get; set; }
        [Required]
        public int AnimalCategoryId { get; set; }
        [ForeignKey("AnimalCategoryId")]
        public AnimalCategory AnimalCategory { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }
    }
}
