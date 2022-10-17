using BLogic.Interfaces;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private Context _db;
        public UnitOfWork( Context context)

         { _db = context; }


        private CompanyRepository _companyRepository;
        public ICompanyRepository CompanyRepository
        {
            get
            {
                if (_companyRepository == null)
                    _companyRepository = new CompanyRepository(_db);

                return _companyRepository;
            }
        }
        private AnimalCategoryRepository _animalCategoryRepository;
        public IAnimalCategoryRepository AnimalCategoryRepository
        {
            get
            {
                if (_animalCategoryRepository == null)
                    _animalCategoryRepository = new AnimalCategoryRepository(_db);

                return _animalCategoryRepository;
            }
        }
        private CustomerRepository _customerRepository;
        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                    _customerRepository = new CustomerRepository(_db);

                return _customerRepository;
            }
        }
        private OrderRepository _orderRepository;
        public IOrderRepository OrderRepository
        {
            get
            {
                if (_orderRepository == null)
                    _orderRepository = new OrderRepository(_db);

                return _orderRepository;
            }
        }
        private ProductRepository _productRepository;
        public IProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                    _productRepository = new ProductRepository(_db);

                return _productRepository;
            }
        }
        private ProductCategoryRepository _productCategoryRepository;
        public IProductCategoryRepository ProductCategoryRepository
        {
            get
            {
                if (_productCategoryRepository == null)
                    _productCategoryRepository = new ProductCategoryRepository(_db);

                return _productCategoryRepository;
            }
        }
        public void Commit()
        {
            try
            {
           _db.SaveChanges();
            }
            catch (Exception ex)
            {
                ex.Source = string.Empty;
            }
        }
    }
}
