using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NLayer.BLL.Repository;
using NLayer.BLL.Service;

namespace NLayer.DAL.Models
{
    public static class ConfigureServices
    {
        public static void AddServices(IServiceCollection services, IConfiguration confign)
        {
            services.AddDbContext<ApDataContext>(options =>
            {
            options.UseSqlServer(confign.GetConnectionString("conn"), action=>{

                action.MigrationsAssembly("NLayer.DAL");
            });
            });

            services.AddScoped<IRepository<Product>, ProductRepository>();
            services.AddScoped<IRepository<Category>, CategoryRepository>();
            services.AddScoped<ICrudService<Product>, ProductService>();
            services.AddScoped<ICrudService<Category>, CategoryService>();
            services.AddScoped<UnitOfWork>();
            services.AddScoped<ProductFeatureRepository>();
            services.AddScoped<CategoryRepository>();
        }
    }
}
