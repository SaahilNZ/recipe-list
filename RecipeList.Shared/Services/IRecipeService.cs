using System;
using System.Collections.Generic;
using RecipeList.Model;

namespace RecipeList.Services
{
    public interface IRecipeService
    {
        List<Recipe> GetRecipes();
        RecipeDetails GetRecipe(int id);
    }
}