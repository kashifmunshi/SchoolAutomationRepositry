using AppContract.Interfaces;
using AppContract.Repositories;
using AppEntity.Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebApp
{
    public class Startup
    {
        private static IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DbEntities>(options =>
            {
                options.UseSqlServer(_config.GetConnectionString("SchoolAutomation"),
                    a => a.MigrationsAssembly("WebApp"));
            });
            services.AddMvc();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
        }

        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}