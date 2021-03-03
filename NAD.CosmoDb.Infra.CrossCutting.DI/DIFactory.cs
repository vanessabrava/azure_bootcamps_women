using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace NAD.CosmoDb.Infra.CrossCutting.DI
{
    public static class DIFactory
    {
        public static void ConfigureDI(IServiceCollection services, IConfiguration configuration)
        {
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<IDbContextDesafioRadix, DbContextDesafioRadix>();

            
        }
    }
}
