using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLogic.Interfaces
{
    public interface IUnitOfWokr
    {
        ICompanyRepository CompanyRepository { get; set; }
        IAnimalCategoryRepository AnimalCategoryRepository { get; set; }
        ICustomerRepositor CustomerRepositor { get; set; }
        IOrderRepository OrderRepository { get; set; }
        IProductRepository ProductRepository { get; set; }
        IProductCategoryRepository ProductCategoryRepository { get; set; }

        void Commit(); //метод для конечной транзакции в базу данных
    }
}
