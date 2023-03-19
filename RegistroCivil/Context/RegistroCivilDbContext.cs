using Microsoft.EntityFrameworkCore;
using RegistroCivil.Models;

namespace RegistroCivil.Context
{
    public class RegistroCivilDbContext:Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Registro> Resgistros { get; set; }
        public RegistroCivilDbContext(DbContextOptions<RegistroCivilDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }

    }
}
