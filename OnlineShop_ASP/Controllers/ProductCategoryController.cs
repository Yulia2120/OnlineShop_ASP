using BLogic.Domain;
using BLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShop_ASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        private readonly IUnitOfWork _ofWork;
        public ProductCategoryController(IUnitOfWork ofWork)
        {
            _ofWork = ofWork;
        }

        [HttpGet]
        public IAsyncEnumerable<ProductCategory> GetAllProdCategory()
        {
            return _ofWork.ProductCategoryRepository.GetAll();
        }
        [HttpPost]
        public async Task<ActionResult> Post(ProductCategory category)
        {
            _ofWork.ProductCategoryRepository.Save(category);
            _ofWork.Commit();
            return Ok(category);
           

        }

    }
}
