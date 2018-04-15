using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipeList.Model;
using RecipeList.Services;

namespace RecipeList.Api.Controllers
{
    [Route("api/[controller]")]
    public class RecipesController : Controller
    {
        private readonly IRecipeService recipeService;

        public RecipesController(IRecipeService recipeService)
        {
            this.recipeService = recipeService;
        }

        // GET api/recipes
        [HttpGet]
        public IEnumerable<Recipe> Get()
        {
            return recipeService.GetRecipes();
        }

        // GET api/recipes/5
        [HttpGet("{id}")]
        public RecipeDetails Get(int id)
        {
            return recipeService.GetRecipe(id);
        }
    }
}
