using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeList.Model;
using RecipeList.Services.Exceptions;

namespace RecipeList.Services
{
    public class RecipeService : IRecipeService
    {
        private List<RecipeDetails> recipes;

        public RecipeService()
        {
            recipes = new List<RecipeDetails>
            {
                new RecipeDetails
                {
                    Id = 1,
                    Name = "Spinach and Feta Scrolls",
                    CreatedBy = new User
                    {
                        FirstName = "John",
                        LastName = "Doe"
                    },
                    Serves = 6,
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "1&frac12; sheets frozen puff pastry, thawed" },
                        new Ingredient { Name = "Spray cooking oil" },
                        new Ingredient { Name = "250g baby spinach" },
                        new Ingredient { Name = "100g crumbled feta cheese" }
                    },
                    Method = new List<string>
                    {
                        "Preheat oven to 200&deg;C (180&deg;C fan-forced).",
                        "Line a large oven tray with baking paper.",
                        "Join pastry sheets, overlapping them by 1cm and pressing together to join.",
                        "Place pastry over the baking paper.",
                        "Spray a medium sized frying pan with oil.",
                        "Place spinach in the frying pan and saut&eacute; over a medium heat for 1-2 minutes, or until just wilted.",
                        "Transfer to a colander and squeeze out excess moisture.",
                        "Spread spinach over pastry, leaving a 3cm border around the edge.",
                        "Sprinkle feta over top.",
                        "Brush pastry edge with a small amount of water and roll up loosely.",
                        "Cut into six equal rounds.",
                        "Arrange the rounds with the cut-side up on the baking tray.",
                        "Bake for 15-20 minutes or until the pastry is crisp and golden."
                    }
                },
                new RecipeDetails
                {
                    Id = 2,
                    Name = "Barbecue Prawn and Peach Skewers",
                    CreatedBy = new User
                    {
                        FirstName = "Jane",
                        LastName = "Doe"
                    },
                    Serves = 6,
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "1&frac12; sheets frozen puff pastry, thawed" },
                        new Ingredient { Name = "Spray cooking oil" },
                        new Ingredient { Name = "250g baby spinach" },
                        new Ingredient { Name = "100g crumbled feta cheese" }
                    },
                    Method = new List<string>
                    {
                        "Preheat oven to 200&deg;C (180&deg;C fan-forced).",
                        "Line a large oven tray with baking paper.",
                        "Join pastry sheets, overlapping them by 1cm and pressing together to join.",
                        "Place pastry over the baking paper.",
                        "Spray a medium sized frying pan with oil.",
                        "Place spinach in the frying pan and saut&eacute; over a medium heat for 1-2 minutes, or until just wilted.",
                        "Transfer to a colander and squeeze out excess moisture.",
                        "Spread spinach over pastry, leaving a 3cm border around the edge.",
                        "Sprinkle feta over top.",
                        "Brush pastry edge with a small amount of water and roll up loosely.",
                        "Cut into six equal rounds.",
                        "Arrange the rounds with the cut-side up on the baking tray.",
                        "Bake for 15-20 minutes or until the pastry is crisp and golden."
                    }
                },
                new RecipeDetails
                {
                    Id = 3,
                    Name = "Lamb Naan Pizzas",
                    CreatedBy = new User
                    {
                        FirstName = "James",
                        LastName = "Dough"
                    },
                    Serves = 6,
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "1&frac12; sheets frozen puff pastry, thawed" },
                        new Ingredient { Name = "Spray cooking oil" },
                        new Ingredient { Name = "250g baby spinach" },
                        new Ingredient { Name = "100g crumbled feta cheese" }
                    },
                    Method = new List<string>
                    {
                        "Preheat oven to 200&deg;C (180&deg;C fan-forced).",
                        "Line a large oven tray with baking paper.",
                        "Join pastry sheets, overlapping them by 1cm and pressing together to join.",
                        "Place pastry over the baking paper.",
                        "Spray a medium sized frying pan with oil.",
                        "Place spinach in the frying pan and saut&eacute; over a medium heat for 1-2 minutes, or until just wilted.",
                        "Transfer to a colander and squeeze out excess moisture.",
                        "Spread spinach over pastry, leaving a 3cm border around the edge.",
                        "Sprinkle feta over top.",
                        "Brush pastry edge with a small amount of water and roll up loosely.",
                        "Cut into six equal rounds.",
                        "Arrange the rounds with the cut-side up on the baking tray.",
                        "Bake for 15-20 minutes or until the pastry is crisp and golden."
                    }
                },
                new RecipeDetails
                {
                    Id = 4,
                    Name = "Salmon and Cucumber Sushi Slice",
                    CreatedBy = new User
                    {
                        FirstName = "Jimmy",
                        LastName = "Doe"
                    },
                    Serves = 6,
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "1&frac12; sheets frozen puff pastry, thawed" },
                        new Ingredient { Name = "Spray cooking oil" },
                        new Ingredient { Name = "250g baby spinach" },
                        new Ingredient { Name = "100g crumbled feta cheese" }
                    },
                    Method = new List<string>
                    {
                        "Preheat oven to 200&deg;C (180&deg;C fan-forced).",
                        "Line a large oven tray with baking paper.",
                        "Join pastry sheets, overlapping them by 1cm and pressing together to join.",
                        "Place pastry over the baking paper.",
                        "Spray a medium sized frying pan with oil.",
                        "Place spinach in the frying pan and saut&eacute; over a medium heat for 1-2 minutes, or until just wilted.",
                        "Transfer to a colander and squeeze out excess moisture.",
                        "Spread spinach over pastry, leaving a 3cm border around the edge.",
                        "Sprinkle feta over top.",
                        "Brush pastry edge with a small amount of water and roll up loosely.",
                        "Cut into six equal rounds.",
                        "Arrange the rounds with the cut-side up on the baking tray.",
                        "Bake for 15-20 minutes or until the pastry is crisp and golden."
                    }
                },
                new RecipeDetails
                {
                    Id = 5,
                    Name = "BBQ Eggplant, Haloumi and Pesto Burgers",
                    CreatedBy = new User
                    {
                        FirstName = "Janette",
                        LastName = "Doe"
                    },
                    Serves = 6,
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "1&frac12; sheets frozen puff pastry, thawed" },
                        new Ingredient { Name = "Spray cooking oil" },
                        new Ingredient { Name = "250g baby spinach" },
                        new Ingredient { Name = "100g crumbled feta cheese" }
                    },
                    Method = new List<string>
                    {
                        "Preheat oven to 200&deg;C (180&deg;C fan-forced).",
                        "Line a large oven tray with baking paper.",
                        "Join pastry sheets, overlapping them by 1cm and pressing together to join.",
                        "Place pastry over the baking paper.",
                        "Spray a medium sized frying pan with oil.",
                        "Place spinach in the frying pan and saut&eacute; over a medium heat for 1-2 minutes, or until just wilted.",
                        "Transfer to a colander and squeeze out excess moisture.",
                        "Spread spinach over pastry, leaving a 3cm border around the edge.",
                        "Sprinkle feta over top.",
                        "Brush pastry edge with a small amount of water and roll up loosely.",
                        "Cut into six equal rounds.",
                        "Arrange the rounds with the cut-side up on the baking tray.",
                        "Bake for 15-20 minutes or until the pastry is crisp and golden."
                    }
                },
                new RecipeDetails
                {
                    Id = 6,
                    Name = "Grilled Nectarines with Passionfruit Yoghurt",
                    CreatedBy = new User
                    {
                        FirstName = "Jack",
                        LastName = "Doe"
                    },
                    Serves = 6,
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "1&frac12; sheets frozen puff pastry, thawed" },
                        new Ingredient { Name = "Spray cooking oil" },
                        new Ingredient { Name = "250g baby spinach" },
                        new Ingredient { Name = "100g crumbled feta cheese" }
                    },
                    Method = new List<string>
                    {
                        "Preheat oven to 200&deg;C (180&deg;C fan-forced).",
                        "Line a large oven tray with baking paper.",
                        "Join pastry sheets, overlapping them by 1cm and pressing together to join.",
                        "Place pastry over the baking paper.",
                        "Spray a medium sized frying pan with oil.",
                        "Place spinach in the frying pan and saut&eacute; over a medium heat for 1-2 minutes, or until just wilted.",
                        "Transfer to a colander and squeeze out excess moisture.",
                        "Spread spinach over pastry, leaving a 3cm border around the edge.",
                        "Sprinkle feta over top.",
                        "Brush pastry edge with a small amount of water and roll up loosely.",
                        "Cut into six equal rounds.",
                        "Arrange the rounds with the cut-side up on the baking tray.",
                        "Bake for 15-20 minutes or until the pastry is crisp and golden."
                    }
                },
                new RecipeDetails
                {
                    Id = 7,
                    Name = "Tomato and Cajun Chicken Skewers with Green Rice",
                    CreatedBy = new User
                    {
                        FirstName = "Josh",
                        LastName = "Doe"
                    },
                    Serves = 6,
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "1&frac12; sheets frozen puff pastry, thawed" },
                        new Ingredient { Name = "Spray cooking oil" },
                        new Ingredient { Name = "250g baby spinach" },
                        new Ingredient { Name = "100g crumbled feta cheese" }
                    },
                    Method = new List<string>
                    {
                        "Preheat oven to 200&deg;C (180&deg;C fan-forced).",
                        "Line a large oven tray with baking paper.",
                        "Join pastry sheets, overlapping them by 1cm and pressing together to join.",
                        "Place pastry over the baking paper.",
                        "Spray a medium sized frying pan with oil.",
                        "Place spinach in the frying pan and saut&eacute; over a medium heat for 1-2 minutes, or until just wilted.",
                        "Transfer to a colander and squeeze out excess moisture.",
                        "Spread spinach over pastry, leaving a 3cm border around the edge.",
                        "Sprinkle feta over top.",
                        "Brush pastry edge with a small amount of water and roll up loosely.",
                        "Cut into six equal rounds.",
                        "Arrange the rounds with the cut-side up on the baking tray.",
                        "Bake for 15-20 minutes or until the pastry is crisp and golden."
                    }
                },
                new RecipeDetails
                {
                    Id = 8,
                    Name = "Pasta and Corn Frittatas",
                    CreatedBy = new User
                    {
                        FirstName = "Jill",
                        LastName = "Doe"
                    },
                    Serves = 6,
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "1&frac12; sheets frozen puff pastry, thawed" },
                        new Ingredient { Name = "Spray cooking oil" },
                        new Ingredient { Name = "250g baby spinach" },
                        new Ingredient { Name = "100g crumbled feta cheese" }
                    },
                    Method = new List<string>
                    {
                        "Preheat oven to 200&deg;C (180&deg;C fan-forced).",
                        "Line a large oven tray with baking paper.",
                        "Join pastry sheets, overlapping them by 1cm and pressing together to join.",
                        "Place pastry over the baking paper.",
                        "Spray a medium sized frying pan with oil.",
                        "Place spinach in the frying pan and saut&eacute; over a medium heat for 1-2 minutes, or until just wilted.",
                        "Transfer to a colander and squeeze out excess moisture.",
                        "Spread spinach over pastry, leaving a 3cm border around the edge.",
                        "Sprinkle feta over top.",
                        "Brush pastry edge with a small amount of water and roll up loosely.",
                        "Cut into six equal rounds.",
                        "Arrange the rounds with the cut-side up on the baking tray.",
                        "Bake for 15-20 minutes or until the pastry is crisp and golden."
                    }
                },
                new RecipeDetails
                {
                    Id = 9,
                    Name = "Chicken and Noodle Lettuce Cups",
                    CreatedBy = new User
                    {
                        FirstName = "Jerry",
                        LastName = "Doe"
                    },
                    Serves = 6,
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "1&frac12; sheets frozen puff pastry, thawed" },
                        new Ingredient { Name = "Spray cooking oil" },
                        new Ingredient { Name = "250g baby spinach" },
                        new Ingredient { Name = "100g crumbled feta cheese" }
                    },
                    Method = new List<string>
                    {
                        "Preheat oven to 200&deg;C (180&deg;C fan-forced).",
                        "Line a large oven tray with baking paper.",
                        "Join pastry sheets, overlapping them by 1cm and pressing together to join.",
                        "Place pastry over the baking paper.",
                        "Spray a medium sized frying pan with oil.",
                        "Place spinach in the frying pan and saut&eacute; over a medium heat for 1-2 minutes, or until just wilted.",
                        "Transfer to a colander and squeeze out excess moisture.",
                        "Spread spinach over pastry, leaving a 3cm border around the edge.",
                        "Sprinkle feta over top.",
                        "Brush pastry edge with a small amount of water and roll up loosely.",
                        "Cut into six equal rounds.",
                        "Arrange the rounds with the cut-side up on the baking tray.",
                        "Bake for 15-20 minutes or until the pastry is crisp and golden."
                    }
                }
            };
        }

        public async Task<List<Recipe>> GetRecipesAsync()
        {
            var result = recipes.Select(r => new Recipe
                {
                    Id = r.Id,
                    Name = r.Name,
                    CreatedBy = r.CreatedBy
                }).ToList();
            return await Task<List<Recipe>>.FromResult(result);
        }

        public async Task<RecipeDetails> GetRecipeAsync(int id)
        {
            try
            {
                var result = recipes.First(r => r.Id == id);
                return await Task<RecipeDetails>.FromResult(result);
            }
            catch (InvalidOperationException)
            {
                throw new RecipeNotFoundException(id);
            }
        }
    }
}