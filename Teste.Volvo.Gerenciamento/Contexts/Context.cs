using Microsoft.EntityFrameworkCore;
using Teste.Volvo.Gerenciamento.Models;

namespace Teste.Volvo.Gerenciamento.Contexts
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Truck> Truck { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
