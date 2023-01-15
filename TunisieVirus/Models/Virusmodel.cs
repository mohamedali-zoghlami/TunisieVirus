using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace TunisieVirus.Models
{

    public class virusCounter
    {
        [Key ]
        public String name { get; set;}
        
        public int TotalConfirmed { get; set; }
        public int TotalDeath { get; set; }
        public int TotalRecovred { get; set; }
        public int NewDeath { get; set; }
        public int NewRecovred { get; set; }
        public int NewConfirmed { get; set;}
        public String description { get; set; }

    }
}