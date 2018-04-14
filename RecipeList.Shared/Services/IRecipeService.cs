using System;
using System.Collections.Generic;
using RecipeList.Model;

namespace RecipeList.Services
{
    interface IRecipeService
    {
        List<Recipe> GetRecipes();
        RecipeDetails GetRecipe(int id);
    }
}