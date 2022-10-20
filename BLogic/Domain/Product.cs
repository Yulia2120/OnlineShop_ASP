
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#pragma warning disable CS8618
namespace BLogic.Domain
{
    public class Product : Identity
    {
        [StringLength(155)]
        public string ProductName { get; set; }
        public string ImgUrl { get; set; }
        [StringLength(2000)]
        public string ProductDescription { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }

     
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }

        public int ProductCategoryId { get; set; }
        [ForeignKey("ProductCategoryId")]
        public virtual ProductCategory ProductCategory { get; set; }

    }

}
