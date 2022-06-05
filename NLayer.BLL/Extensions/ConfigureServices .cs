using CrudOperations.API.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NLayer.BLL.Repository;

namespace NLayer.DAL.Models
{
    public static class ConfigureServices
    {
        public static void AddServices(IServiceCollection services, IConfiguration confign)
        {
            services.AddDbContext<MyDataContext>(options =>
            {
                options.UseSqlServer(confign.GetConnectionString("WebApiDatabase"));
            });

            services.AddScoped<IRepository<Product>, ProductRepository>();
            services.AddScoped<IRepository<Category>, CategoryRepository>();
            services.AddScoped<ICrudService<Product>, ProductService>();
            services.AddScoped<ICrudService<Category>, CategoryService>();

        }
    }
}
