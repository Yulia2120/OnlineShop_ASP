using BLogic.Domain;

namespace BLogic.Interfaces
{
    public interface ICompanyRepository: IRepository<Company>
    {
        public Company FindCompanyName(string title);
       
    }
}
