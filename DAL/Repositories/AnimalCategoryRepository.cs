using BLogic.Domain;
using BLogic.Interfaces;

namespace DAL.Repositories
{
    public class AnimalCategoryRepository : Repository<AnimalCategory>, IAnimalCategoryRepository
    {
        public AnimalCategoryRepository(Context context) : base(context)
        {
        }
    }
}
