using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;

namespace RecipeList.DataAccess
{
    public class RecipesContextFactory : IDesignTimeDbContextFactory<RecipesContext>
    {
        private static readonly string DB_PATH_ENV = "RECIPE_LIST_DB";

        public RecipesContext CreateDbContext(string[] args)
        {
            var dbPath = Environment.GetEnvironmentVariable(DB_PATH_ENV);
            if (string.IsNullOrWhiteSpace(dbPath))
            {
                throw new InvalidOperationException($"{DB_PATH_ENV} environment variable not configured.");
            }
            return new RecipesContext(dbPath);
        }
    }
}