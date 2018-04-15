using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RecipeList.Model;

namespace RecipeList.Services
{
    public interface IRecipeService
    {
        Task<List<Recipe>> GetRecipesAsync();
        Task<RecipeDetails> GetRecipeAsync(long id);
    }
}