using BLogic.Domain;

namespace BLogic.Interfaces
{
    public interface ICompanyRepository: IRepository<Company>
    {
        //для добавления методов с которыми будет работать только Company
    }
}
