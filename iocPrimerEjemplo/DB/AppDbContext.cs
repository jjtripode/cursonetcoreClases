using System;
using iocPrimerEjemplo.DomainModel;
using Microsoft.EntityFrameworkCore;

namespace iocPrimerEjemplo.DB
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }
        
        public DbSet<Mecanico> Mecanico {get;set;}
        public DbSet<Pintor> Pintor {get;set;}
        public DbSet<RepararAuto> TareasRepararAuto {get;set;}
        public DbSet<Pintar> TareasPintar {get;set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Mecanico>().HasData(
                new Mecanico()
                
            );

            builder.Entity<Pintor>().HasData(
                new Pintor()
            );

  builder.Entity<RepararAuto>().HasData(
                new RepararAuto(),
                new RepararAuto(),
                new RepararAuto(),
                new RepararAuto()
            );

  builder.Entity<Pintar>().HasData(
                new Pintar(),
                new Pintar(),
                new Pintar()
            );
            base.OnModelCreating(builder);
        }
    }
}