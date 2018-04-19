using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RecipeList.DataAccess;
using RecipeList.Services;

namespace RecipeList.Api
{
    public class Startup
    {
        private static readonly string DB_PATH = "data/recipes.db";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddSingleton<RecipesContext>(new RecipesContext(DB_PATH));
            services.AddTransient<IRecipeService, RecipeService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            Directory.CreateDirectory(Path.GetDirectoryName(DB_PATH));
            var context = app.ApplicationServices.GetService<RecipesContext>();
            context.Database.Migrate();

            app.UseMvc();
        }
    }
}
