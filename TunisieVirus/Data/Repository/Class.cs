using System.Linq.Expressions;
using TunisieVirus.Data.Context;
using TunisieVirus.Models;

namespace TunisieVirus.Data.Repository
{
    public class VirusCounterRepository : IRepository<virusCounter>
    {
        private readonly ApplicationContext applicationContext;
        public VirusCounterRepository(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public virusCounter Get(String name)
        {
            try
            {

                return applicationContext.Set<virusCounter>().Find(name);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<virusCounter> GetAll()
        {
            try { return applicationContext.Set<virusCounter>().ToList(); }
            catch (Exception ex) { throw ex; }
        }
    


    }
}
