using BLogic.Domain;
using BLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShop_ASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly IUnitOfWork _ofWork;
        public CompanyController(IUnitOfWork ofWork)
        {
            _ofWork = ofWork;

        }

        [HttpGet]
        public IAsyncEnumerable<Company> GetAllcompanies()
        {
            return _ofWork.CompanyRepository.GetAll();
        }

    }
}
