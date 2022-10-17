using BLogic.Domain;
using BLogic.Interfaces;

namespace DAL.Repositories
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(Context context) : base(context)
        { }
       
        public Company FindCompanyName(string name)
        {
#pragma warning disable CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
            return _dbContext.Companies.OrderBy(x => x.CompanyName).FirstOrDefault();
#pragma warning restore CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
        }
    }
    
}
