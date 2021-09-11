using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tfzr_rsok_autosalon.Data;
using tfzr_rsok_autosalon.Data.Repository;
using tfzr_rsok_autosalon.Data.Repository.IRepository;
using tfzr_rsok_autosalon.Services;
using tfzr_rsok_autosalon.Services.IServices;

namespace tfzr_rsok_autosalon
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddMvc().AddRazorPagesOptions(options => {
                options.Conventions.AddAreaPageRoute("Identity", "/Account/Login", "/account/login");
                options.Conventions.AddAreaPageRoute("Identity", "/Account/Register", "/account/register");
            }).SetCompatibilityVersion(CompatibilityVersion.Latest);
            services.AddRouting(x => x.LowercaseUrls = true);
            services.AddRouting(x => x.AppendTrailingSlash = true);
            services.AddScoped<ICarsRepository, CarsRepository>();
            services.AddScoped<ICarsService, CarsService>();
            services.AddScoped<ICategorizesRepository, CategorizesRepository>();
            services.AddScoped<ICarModelsRepository, CarModelsRepository>();
            services.AddScoped<IManufacturesRepository, ManufacturesRepository>();
            services.AddScoped<ICarModelsService, CarModelsService>();
            services.AddScoped<ICarsService, CarsService>();
            services.AddScoped<ICategorizesService, CategorizesService>();
            services.AddScoped<IManufacturersService, ManufacturersService>();
            services.AddScoped<IOrdersService, OrdersService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/home/error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
