using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RecipeList.Services;

namespace RecipeList.Web
{
    public class Startup
    {
        private static readonly string API_URL_ENV = "RECIPE_LIST_API";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            string apiUrl = Environment.GetEnvironmentVariable(API_URL_ENV);
            if (string.IsNullOrWhiteSpace(apiUrl))
            {
                throw new InvalidOperationException($"{API_URL_ENV} environment variable not configured.");
            }
            services.AddSingleton<IRecipeService>(new RecipeApiService(apiUrl));
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
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
