using BLogic.Domain;

namespace BLogic.Interfaces
{
    public interface IOrderRepository: IRepository<Order>
    {
        //для добавления методов с которыми будет работать только Order
    }
}
