using BLogic.Domain;

namespace BLogic.Interfaces
{
    public interface IAnimalCategoryRepository: IRepository<AnimalCategory>
    {
        //для добавления методов с которыми будет работать только AnimalCategory
    }
}
