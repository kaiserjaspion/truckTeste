using Microsoft.EntityFrameworkCore;
using Teste.Volvo.Gerenciamento.Models;

namespace Teste.Volvo.Gerenciamento.Contexts
{
    public class Context : DbContext
    {
        public Context() 
        {

        }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public virtual DbSet<Truck> Trucks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
