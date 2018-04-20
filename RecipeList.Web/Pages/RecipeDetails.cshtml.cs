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
        public List<Step> RecipeSteps { get; set; }

        public RecipeDetailsModel(IRecipeService recipeService)
        {
            this.recipeService = recipeService;
        }

        public async Task OnGetAsync(long id)
        {
            Recipe = await recipeService.GetRecipeAsync(id);
            RecipeSteps = Recipe.Method.OrderBy(r => r.StepNumber).ToList();
        }
    }
}
