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
    public static class ValidationService
    {
        public static void Validate(this RecipeDetails recipe)
        {
            var reasons = InvalidRecipeException.Reason.None;

            if (recipe == null)
            {
                throw new InvalidRecipeException();
            }

            if (recipe.Ingredients == null || recipe.Ingredients.Count < 1)
            {
                reasons |= InvalidRecipeException.Reason.NoIngredients;
            }
            if (recipe.Method == null || recipe.Method.Count < 1)
            {
                reasons |= InvalidRecipeException.Reason.NoMethodSteps;
            }
            if (recipe.User == null)
            {
                reasons |= InvalidRecipeException.Reason.NoUser;
            }

            if (reasons != InvalidRecipeException.Reason.None)
            {
                throw new InvalidRecipeException(reasons);
            }
        }
    }
}