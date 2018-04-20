using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeList.DataAccess;
using RecipeList.Model;
using RecipeList.Services.Exceptions;

namespace RecipeList.Services
{
    public class RecipeService : IRecipeService
    {
        private List<RecipeDetails> recipes;
        private readonly RecipesContext context;

        public RecipeService(RecipesContext context)
        {
            this.context = context;
        }

        public async Task<List<Recipe>> GetRecipesAsync()
        {
            var result = recipes.Select(r => new Recipe
            {
                RecipeId = r.RecipeId,
                Name = r.Name,
                UserId = r.UserId
            }).ToList();
            return await Task<List<Recipe>>.FromResult(result);
        }

        public async Task<RecipeDetails> GetRecipeAsync(long id)
        {
            try
            {
                var result = recipes.First(r => r.RecipeId == id);
                return await Task<RecipeDetails>.FromResult(result);
            }
            catch (InvalidOperationException)
            {
                throw new RecipeNotFoundException(id);
            }
        }
    }
}