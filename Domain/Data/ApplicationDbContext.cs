using CRUD_ONION_API.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_ONION_API.Domain.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Empresas> Empresa { get; set; }
        public DbSet<Colaboradores> Colaborador { get; set; }
    }
}
