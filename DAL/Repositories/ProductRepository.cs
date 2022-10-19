#pragma warning disable CS8603
using BLogic.Domain;
using BLogic.Interfaces;

namespace DAL.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(Context context) : base(context)
        {
        }

        public Product FindProductName(string title)
        {
            return _dbContext.Products.OrderBy(x => x.ProductName).FirstOrDefault();
        }
    }
}
