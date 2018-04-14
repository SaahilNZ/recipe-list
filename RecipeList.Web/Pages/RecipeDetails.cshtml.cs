using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeList.Model;

namespace RecipeList.Web.Pages
{
    public class RecipeDetailsModel : PageModel
    {
        public RecipeDetails Recipe { get; set; }

        public void OnGet()
        {
            Recipe = new RecipeDetails
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
