#pragma warning disable CS8603
using BLogic.Domain;
using BLogic.Interfaces;

namespace DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : Identity
    {
        private Context _dbContext;

        public Repository(Context context)
        {
            _dbContext = context;
        }
        public T FindById(int id)
        {
            return _dbContext.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public List<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public void Save(T item)
        {
            _dbContext.Set<T>().Add(item);
        }
    }
}
