using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeList.Model;

namespace RecipeList.Web.Pages
{
    public class IndexModel : PageModel
    {
        public List<Recipe> Recipes { get; set; }

        public void OnGet()
        {
            Recipes = new List<Recipe>
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
    }
}
