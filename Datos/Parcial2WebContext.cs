using Microsoft.EntityFrameworkCore;
using Entity;

namespace Datos
{
    public class Parcial2WebContext: DbContext
    {
        public Parcial2WebContext(DbContextOptions options):base(options)
        {
            
        }
        
        public DbSet<Persona>personas{get;set;}
        public DbSet<Vacuna>vacunas{get;set;}
    }
}