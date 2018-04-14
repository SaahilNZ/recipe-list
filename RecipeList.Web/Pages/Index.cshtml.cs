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
    public class IndexModel : PageModel
    {
        public List<Recipe> Recipes { get; set; }

        public void OnGet()
        {
            var service = new RecipeService();
            Recipes = service.GetRecipes();
        }
    }
}
