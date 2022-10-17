using BLogic.Domain;

namespace BLogic.Interfaces
{
    public interface IProductRepository: IRepository<Product>
    {
        //для добавления методов с которыми будет работать только Product
    }
}
