using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;

namespace RecipeList.DataAccess
{
    public class RecipesContextFactory : IDesignTimeDbContextFactory<RecipesContext>
    {
        private static readonly string DB_PATH = "data/recipes.db";

        public RecipesContext CreateDbContext(string[] args)
        {
            return new RecipesContext(DB_PATH);
        }
    }
}