using BLogic.Domain;

namespace BLogic.Interfaces
{
    public interface ICustomerRepository: IRepository<Customer>
    {
        //для добавления методов с которыми будет работать только Customer
    }
}
