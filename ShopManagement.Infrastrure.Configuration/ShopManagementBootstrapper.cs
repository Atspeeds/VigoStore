using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopManagement.Application;
using ShopManagement.Domain.ProductAgg;
using ShopManagement.Infrastrure.EFCore;
using ShopManagement.Infrastrure.EFCore.Repository;
using SopeManagement.Application.Contract.Product;

namespace ShopManagement.Infrastrure.Con
{
    public class ShopManagementBootstrapper
    {
        public static void Configure(IServiceCollection service,string connectionString)
        {


            //Product
            service.AddTransient<IProductApplication, ProductApplication>();
            service.AddTransient<IProductRepository, ProductRepository>();

            //Used Sql Server
            service.AddDbContext<ShopContext>(options => options.UseSqlServer(connectionString));

        }

    }
}
