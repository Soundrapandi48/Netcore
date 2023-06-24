using APIProject.Contracts;
using APIProject.Entities;
using APIProject.Repository;
using Microsoft.EntityFrameworkCore;

namespace APIProject.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader());
            });
        }
        public static void ConfigureRepositoryWrapper(this IServiceCollection services )
        {
            services.AddScoped<IUserData,UserRepository>();
            services.AddScoped<IManufacturer, ManufacturerRepository>();
        }
        public static void ConfigureSqlServer(this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<RepositoryContext>(options => 
            options.UseSqlServer(config.GetConnectionString("Sql")));
        }
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            //services.AddLogging(options => {})
        }
    }
}
