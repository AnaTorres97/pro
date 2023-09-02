using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using ProyectoInvestigacion.Shared.Entidades;

namespace ProyectoInvestigacion.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
             
        }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Investigador> Investigadores { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Proyecto>().HasIndex(c => c.NombrePro).IsUnique();
            modelBuilder.Entity<Investigador>().HasIndex(c => c.Nombre).IsUnique();
        }


    }
}
