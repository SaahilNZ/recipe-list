using System;
using System.Collections.Generic;
using RecipeList.Model;

namespace RecipeList.Services
{
    public class RecipeService : IRecipeService
    {
        public List<Recipe> GetRecipes()
        {
            return new List<Recipe>
            {
                new Recipe
                {
                    Name = "Spinach and Feta Scrolls",
                    CreatedBy = new User
                    {
                        FirstName = "John",
                        LastName = "Doe"
                    }
                },
                new Recipe
                {
                    Name = "Barbecue Prawn and Peach Skewers",
                    CreatedBy = new User
                    {
                        FirstName = "Jane",
                        LastName = "Doe"
                    }
                },
                new Recipe
                {
                    Name = "Lamb Naan Pizzas",
                    CreatedBy = new User
                    {
                        FirstName = "James",
                        LastName = "Dough"
                    }
                },
                new Recipe
                {
                    Name = "Salmon and Cucumber Sushi Slice",
                    CreatedBy = new User
                    {
                        FirstName = "Jimmy",
                        LastName = "Doe"
                    }
                },
                new Recipe
                {
                    Name = "BBQ Eggplant, Haloumi and Pesto Burgers",
                    CreatedBy = new User
                    {
                        FirstName = "Janette",
                        LastName = "Doe"
                    }
                },
                new Recipe
                {
                    Name = "Grilled Nectarines with Passionfruit Yoghurt",
                    CreatedBy = new User
                    {
                        FirstName = "Jack",
                        LastName = "Doe"
                    }
                },
                new Recipe
                {
                    Name = "Tomato and Cajun Chicken Skewers with Green Recipe",
                    CreatedBy = new User
                    {
                        FirstName = "Josh",
                        LastName = "Doe"
                    }
                },
                new Recipe
                {
                    Name = "Pasta and Corn Frittatas",
                    CreatedBy = new User
                    {
                        FirstName = "Jill",
                        LastName = "Doe"
                    }
                },
                new Recipe
                {
                    Name = "Chicken and Noodle Lettuce Cups",
                    CreatedBy = new User
                    {
                        FirstName = "Jerry",
                        LastName = "Doe"
                    }
                }
            };
        }

        public RecipeDetails GetRecipe(int id)
        {
            return new RecipeDetails
            {
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
            };
        }
    }
}