using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeList.Model;
using RecipeList.Services;

namespace RecipeList.Web.Pages
{
    public class RecipeDetailsModel : PageModel
    {
        private readonly IRecipeService recipeService;

        public RecipeDetails Recipe { get; set; }

        public RecipeDetailsModel(IRecipeService recipeService)
        {
            this.recipeService = recipeService;
        }

        public void OnGet()
        {
            Recipe = recipeService.GetRecipe(0);
        }
    }
}
