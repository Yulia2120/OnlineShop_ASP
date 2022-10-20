using BLogic.Domain;
using BLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShop_ASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IUnitOfWork _ofWork;
        public OrderController(IUnitOfWork ofWork)
        {
            _ofWork = ofWork;

        }

        [HttpGet]
        public IAsyncEnumerable<Order> GetAllProducts()
        {
            return _ofWork.OrderRepository.GetAll();
        }
    }
}
