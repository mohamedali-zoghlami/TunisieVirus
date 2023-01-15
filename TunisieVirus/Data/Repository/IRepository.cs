using System.Linq.Expressions;

namespace TunisieVirus.Data.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(String name);
        IEnumerable<TEntity> GetAll();
       
    }
}
