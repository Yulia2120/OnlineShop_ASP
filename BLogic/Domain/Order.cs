namespace BLogic.Domain
{
    public class Order:Identity
    {
       public string CustomerId { get; set; }=string.Empty;
       public DateTime DateTime { get; set; }

    }
}
