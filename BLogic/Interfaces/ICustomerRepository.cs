using BLogic.Domain;

namespace BLogic.Interfaces
{
    public interface ICustomerRepositor: IRepository<Customer>
    {
        //для добавления методов с которыми будет работать только Customer
    }
}
