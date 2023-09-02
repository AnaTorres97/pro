using Microsoft.EntityFrameworkCore;
using proyectoinvestigacion.Shared.Entidades;

namespace proyectoinvestigacion.API.Data
{
    public class DataContext : DbContext
    {
    public DataContext(DbContextOptions<DataContext> options) : base (options) {
        
        }  
    public DbSet<proyectos>Proyectos { get; set; }

        public override void OnModel

    }
  
}

