using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.JsonPatch.Operations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Planta.DBActions;
//using Planta.Repository;

namespace Planta
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
              .SetBasePath(env.ContentRootPath)
              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
              .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
              .AddEnvironmentVariables();
            Configuration = builder.Build();

        }

        public IConfiguration Configuration { get; }
 

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {           
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            //services.AddSingleton<ActionManager>(new ActionManager(Configuration["ConnectionString"]));
            // services.AddTransient<ICountryService, CountryService>();
            //  services.AddTransient<ActionManager>(); //(typeof(IActionManager), typeof(ActionManager));

            //services.AddSingleton<IActionManager>(new ActionManager(Configuration["ConnectionString"]));
            services.AddScoped<IDbAdaptor>(sp => new DbAdaptorManager(Configuration["ConnectionString"]));
            //  
            //services.AddHttpClient<IActionManager,ActionManager>(client => client.BaseAddress =
            // new Uri(Configuration["ConnectionString"]));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            //app.Use(next =>
            //{
            
            //    return async context =>
            //    {
            //        var a = context.Request.Path.Value.ToLower();

            //    };
            //});


            app.UseMvc(routes =>
            {
                 

                routes.MapRoute(
                    name: "default",
                    template: "{controller=AdministratorDashboard}/{action=DashboardView}/{id?}");
            });
        }
    }
}
