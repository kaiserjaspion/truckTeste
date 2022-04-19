using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Teste.Volvo.Gerenciamento.Contexts;
using Teste.Volvo.Gerenciamento.Repositories;
using Teste.Volvo.Gerenciamento.Services;
using Teste.Volvo.Gerenciamento.Services.Interfaces;

namespace Teste.Volvo.Gerenciamento.Injections
{
    public class Injections
    {
        public Injections(IServiceCollection service, IConfiguration configuration)
        {
            this.InjectionConfigure(service,configuration);
        }

        private void InjectionConfigure(IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration["ConnectionString"];

            services.AddDbContext<Context>(options => options.UseSqlServer(connection));
            
            services.AddSingleton<IConfiguration>(configuration);

            services.AddScoped<TruckRepository>(t => new TruckRepository(t.GetService<Context>()));

            services.AddTransient<ITruckService, TruckService>();

        }

    }
}
