using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeList.DataAccess;
using RecipeList.Model;
using RecipeList.Services.Exceptions;

namespace RecipeList.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly RecipesContext context;

        public RecipeService(RecipesContext context)
        {
            this.context = context;
        }

        public async Task<List<Recipe>> GetRecipesAsync()
        {
            var recipes = context.Recipes.Include(r => r.User).ToList();
            var result = recipes.Select(r => new Recipe
            {
                RecipeId = r.RecipeId,
                Name = r.Name,
                UserId = r.UserId,
                User = r.User
            }).ToList();
            return await Task<List<Recipe>>.FromResult(result);
        }

        public async Task<RecipeDetails> GetRecipeAsync(long id)
        {
            try
            {
                var recipes = context.Recipes
                    .Include(r => r.Method)
                    .Include(r => r.Ingredients)
                    .Include(r => r.User).ToList();
                var result = recipes.First(r => r.RecipeId == id);
                return await Task<RecipeDetails>.FromResult(result);
            }
            catch (InvalidOperationException)
            {
                throw new RecipeNotFoundException(id);
            }
        }

        public async Task<RecipeDetails> PostRecipeAsync(RecipeDetails recipe)
        {
            context.Users.Add(recipe.User);
            context.Ingredients.AddRange(recipe.Ingredients);
            context.RecipeSteps.AddRange(recipe.Method);
            context.Recipes.Add(recipe);
            await context.SaveChangesAsync();
            
            return recipe;
        }
    }
}