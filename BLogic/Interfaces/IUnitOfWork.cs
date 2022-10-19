namespace BLogic.Interfaces
{
    public interface IUnitOfWork
    {
        ICompanyRepository CompanyRepository { get;}
        IAnimalCategoryRepository AnimalCategoryRepository { get;}
        ICustomerRepository CustomerRepository { get; }
        IOrderRepository OrderRepository { get; }
        IProductRepository ProductRepository { get; }
        IProductCategoryRepository ProductCategoryRepository { get; }

        void Commit(); //метод для конечной транзакции в базу данных
    }
}
