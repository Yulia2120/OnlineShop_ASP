namespace BLogic.Domain
{
    public class AnimalCategory:Identity
    {
        public string AnimalName { get; set; }=string.Empty;
        public List<ProductCategory> ProductCategory { get; set; }
    }
}
