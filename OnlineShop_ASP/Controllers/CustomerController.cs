using BLogic.Domain;
using BLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShop_ASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IUnitOfWork _ofWork;
        public CustomerController(IUnitOfWork ofWork)
        {
            _ofWork = ofWork;

        }

        [HttpGet]
        public IAsyncEnumerable<Customer> GetAllProducts()
        {
            return _ofWork.CustomerRepository.GetAll();
        }
    }
}
