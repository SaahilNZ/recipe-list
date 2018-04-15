using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipeList.Model;
using RecipeList.Services;
using RecipeList.Services.Exceptions;

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
        public ApiResponse<List<Recipe>> Get()
        {
            return ApiResponse<List<Recipe>>.FromData(recipeService.GetRecipes());
        }

        // GET api/recipes/5
        [HttpGet("{id}")]
        public ApiResponse<RecipeDetails> Get(int id)
        {
            try
            {
                return ApiResponse<RecipeDetails>.FromData(recipeService.GetRecipe(id));
            }
            catch (RecipeNotFoundException e)
            {
                return ApiResponse<RecipeDetails>.FromErrorCode(e.Message,
                    ErrorCode.RecipeNotFound, new Dictionary<string, object>
                        {
                            { "id", id }
                        });
            }

        }
    }
}
