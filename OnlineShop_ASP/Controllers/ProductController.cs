using BLogic.Domain;
using BLogic.Interfaces;
using DAL;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShop_ASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
       private readonly  IUnitOfWork _ofWork;
        public ProductController(IUnitOfWork ofWork)
        {
            _ofWork = ofWork;
           
        }

        [HttpGet("GetAllProducts")]
        public IAsyncEnumerable<Product> GetAllProducts()
        {
            return _ofWork.ProductRepository.GetAll();
        }
        [HttpPost]
        public async Task<ActionResult> Post(Product product)
        {
            _ofWork.ProductRepository.Save(product);
            _ofWork.Commit();
            return Ok(product);
            //при вставке добавлять все nameid, кроме обычных id

        }
    }
}
