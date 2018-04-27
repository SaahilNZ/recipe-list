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
        public async Task<ApiResponse<List<Recipe>>> Get()
        {
            return ApiResponse<List<Recipe>>.FromData(await recipeService.GetRecipesAsync());
        }

        // GET api/recipes/5
        [HttpGet("{id}", Name = "GetRecipe")]
        public async Task<IActionResult> Get(long id)
        {
            try
            {
                var response = ApiResponse<RecipeDetails>.FromData(
                    await recipeService.GetRecipeAsync(id));
                return Ok(response);
            }
            catch (RecipeNotFoundException e)
            {
                var response = ApiResponse<RecipeDetails>.FromErrorCode(e.Message,
                    ErrorCode.NotFound, new Dictionary<string, object>
                        {
                            { "id", id }
                        });
                return NotFound(response);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] RecipeDetails recipe)
        {
            ApiResponse<RecipeDetails> response;
            try
            {
                await recipeService.CreateRecipeAsync(recipe);
                response = ApiResponse<RecipeDetails>.FromData(recipe);
            }
            catch (InvalidRecipeException e)
            {
                response = ApiResponse<RecipeDetails>.FromErrorCode(e.Message,
                    ErrorCode.InvalidRequest, new Dictionary<string, object>
                    {
                        { "reasons", e.Reasons }
                    });
                return BadRequest(response);
            }
            return CreatedAtRoute("GetRecipe", new { id = recipe.RecipeId }, response);
        }
    }
}
