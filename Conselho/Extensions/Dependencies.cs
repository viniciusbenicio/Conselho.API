using Conselho.API.Models;
using Conselho.API.Repository;
using Conselho.API.Repository.Interfaces;
using Conselho.API.Services;
using Conselho.API.Services.Interfaces;
using Microsoft.Data.SqlClient;

namespace Conselho.API.Extensions
{
    public static class Dependencies
    {
        public static void AddSqlConnection(
            this IServiceCollection services,
            string connectionString)
        {
            services.AddScoped<SqlConnection>(x
                => new SqlConnection(connectionString));
        }
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IRepository<Usuario>, Repository<Usuario>>();
            services.AddTransient<IRepository<Slip>, Repository<Slip>>();
            services.AddTransient<IUsuarioConselhoRepository, UsuarioConselhoRepository>();
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IAdviceSlipServices, AdviceSlipServices>();
        }
    }
}
