using Microsoft.EntityFrameworkCore;
using RecipeList.Model;
using System.Collections.Generic;

namespace RecipeList.DataAccess
{
    public class RecipesContext : DbContext
    {
        private readonly string sqliteDbPath;
        
        public DbSet<RecipeDetails> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Step> RecipeSteps { get; set; }
        public DbSet<User> Users { get; set; }

        public RecipesContext(string sqliteDbPath)
        {
            this.sqliteDbPath = sqliteDbPath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={sqliteDbPath}");
        }
    }
}