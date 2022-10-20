#pragma warning disable CS8603
using BLogic.Domain;
using BLogic.Interfaces;
using Microsoft.EntityFrameworkCore;

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


        //public IEnumerable<Product> GetProduct()
        //{
        //    //  return _dbContext.Products.Include(x => x.ProductCategory).Include(c => c.ProductCategory.AnimalCategory).Include(c => c.Company).ToList();
        //      //return _dbContext.Products.Include(x => x.ProductCategory).Where(x=> x.ProductCategoryId == x.Id);
        //}
    }
}
