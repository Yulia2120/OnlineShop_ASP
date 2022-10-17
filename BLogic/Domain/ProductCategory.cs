namespace BLogic.Domain
{
    public class ProductCategory:Identity
    {
        public string CategoryName { get; set; }=string.Empty;
        public AnimalCategory AnimalCategory { get; set; }
        public List<Product> Products { get; set; }

    }
}
