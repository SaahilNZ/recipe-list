using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeList.Model;
using RecipeList.Services;
using RecipeList.Services.Exceptions;

namespace RecipeList.Web.Pages
{
    public class CreateRecipeModel : PageModel
    {
        private readonly Dictionary<InvalidRecipeException.Reason, string> INVALID_RECIPE_ERRORS =
            new Dictionary<InvalidRecipeException.Reason, string>
            {
                [InvalidRecipeException.Reason.NullRecipe] = "An unexpected error occurred.",
                [InvalidRecipeException.Reason.NoIngredients] = "Recipe needs at least one ingredient.",
                [InvalidRecipeException.Reason.NoMethodSteps] = "Recipe needs at least one method step.",
                [InvalidRecipeException.Reason.NoUser] = "You must be signed in to create recipes."
            };

        private readonly IRecipeService recipeService;

        [BindProperty]
        public RecipeDetails Recipe { get; set; }

        public bool DisplayErrorMessage { get; set; }
        public string ErrorMessage { get; set; }

        public CreateRecipeModel(IRecipeService recipeService)
        {
            this.recipeService = recipeService;
            DisplayErrorMessage = false;
            ErrorMessage = "";
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
            List<Ingredient> ingredients = new List<Ingredient>();
            var ingredientStrings = Request.Form["ingredients"].ToList();
            ingredients.AddRange(ingredientStrings.Select(s => new Ingredient { Name = s }));

            List<Step> method = new List<Step>();
            var methodStrings = Request.Form["method"].ToList();
            for (int i = 0; i < methodStrings.Count; i++)
            {
                method.Add(new Step { StepNumber = i + 1, Description = methodStrings[i] });
            }

            var recipe = new RecipeDetails
            {
                Name = Recipe.Name,
                Serves = Recipe.Serves,
                Ingredients = ingredients,
                Method = method,
                User = user
            };

            try
            {
                await recipeService.CreateRecipeAsync(recipe);
                return RedirectToPage("./Index");
            }
            catch (InvalidRecipeException e)
            {
                var reasonFlags = Enum.GetValues(typeof(InvalidRecipeException.Reason))
                    .Cast<InvalidRecipeException.Reason>()
                    .Where(r => e.Reasons.HasFlag(r));
                var errorMessages = new List<string>();
                foreach (var error in INVALID_RECIPE_ERRORS)
                {
                    if (reasonFlags.Contains(error.Key))
                    {
                        errorMessages.Add(error.Value);
                    }
                }
                ErrorMessage = String.Join("<br/>", errorMessages);
                DisplayErrorMessage = true;
                return Page();
            }
        }
    }
}
