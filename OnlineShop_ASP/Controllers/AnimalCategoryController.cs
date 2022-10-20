using BLogic.Domain;
using BLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShop_ASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalCategoryController : ControllerBase
    {
        private readonly IUnitOfWork _ofWork;
        public AnimalCategoryController(IUnitOfWork ofWork)
        {
            _ofWork = ofWork;
        }

        [HttpGet]
        public IAsyncEnumerable<AnimalCategory> GetAllAnimalCategory()
        {
            return _ofWork.AnimalCategoryRepository.GetAll();
        }
    }
}
