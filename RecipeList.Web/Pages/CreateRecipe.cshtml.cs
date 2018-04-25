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
    public class CreateRecipeModel : PageModel
    {
        private readonly IRecipeService recipeService;

        [BindProperty]
        public RecipeDetails Recipe { get; set; }

        public CreateRecipeModel(IRecipeService recipeService)
        {
            this.recipeService = recipeService;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            User user = new User
            {
                FirstName = "Jenny",
                LastName = "Doe"
            };
            List<Ingredient> ingredients = new List<Ingredient>
            {
                new Ingredient { Name = "Ingredient 1" },
                new Ingredient { Name = "Ingredient 2" },
                new Ingredient { Name = "Ingredient 3" },
                new Ingredient { Name = "Ingredient 4" },
                new Ingredient { Name = "Ingredient 5" }
            };
            List<Step> method = new List<Step>
            {
                new Step { StepNumber = 1, Description = "Step 1" },
                new Step { StepNumber = 2, Description = "Step 2" },
                new Step { StepNumber = 3, Description = "Step 3" },
                new Step { StepNumber = 4, Description = "Step 4" },
                new Step { StepNumber = 5, Description = "Step 5" }
            };
            var recipe = new RecipeDetails
            {
                Name = Recipe.Name,
                Serves = Recipe.Serves,
                Ingredients = ingredients,
                Method = method,
                User = user
            };

            await recipeService.PostRecipeAsync(recipe);
            return RedirectToPage("./Index");
        }
    }
}
