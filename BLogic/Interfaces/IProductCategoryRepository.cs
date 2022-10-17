using BLogic.Domain;

namespace BLogic.Interfaces
{
    public interface IProductCategoryRepository: IRepository<ProductCategory>
    {
        //для добавления методов с которыми будет работать только ProductCategory
    }
}
