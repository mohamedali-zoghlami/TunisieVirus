using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Xml.Linq;
using TunisieVirus.Models;

namespace TunisieVirus.Data.Context
{
    public class ApplicationContext : DbContext
    {
        private static ApplicationContext _contextinstance=null;
        public DbSet<virusCounter> VirusCounters { get; set; }
  
        public static ApplicationContext Instance
        {
            get
            {
                if (_contextinstance == null)
                {
                    var optionBuilder = new DbContextOptionsBuilder<ApplicationContext>();
                    optionBuilder.UseSqlite(@"Data Source=D:\Downloads\sqlite-tools-win32-x86-3400000\TunisieViruss.db");
                    _contextinstance = new ApplicationContext(optionBuilder.Options);
                }
                return _contextinstance;
            }


        }
        private ApplicationContext(DbContextOptions o) : base(o)
        {
            Debug.WriteLine("context    instantiation ");
        }
       
    }
}
