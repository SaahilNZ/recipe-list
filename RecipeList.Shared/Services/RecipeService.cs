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
                    Serves = 8,
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Zest and juice of 1 lemon" },
                        new Ingredient { Name = "Zest and juice of 1 lime" },
                        new Ingredient { Name = "1 Tbsp olive oil" },
                        new Ingredient { Name = "2 cloves garlic, crushed" },
                        new Ingredient { Name = "2 tsp honey" },
                        new Ingredient { Name = "1 tsp cracked black pepper" },
                        new Ingredient { Name = "1kg raw prawns, peeled, deveined, tails intact" },
                        new Ingredient { Name = "6 peaches, stone removed and quartered" },
                        new Ingredient { Name = "2 spring onions, cut into 4cm pieves" },
                        new Ingredient { Name = "8 bamboo skewers, soaked" }
                    },
                    Method = new List<string>
                    {
                        "In a large bowl, combine zests, juices, oil, garlic, honey and pepper.",
                        "Add prawns, turning to coat. Leave to marinate for at least 10 minutes.",
                        "Thread prawns, peach pieces and spring onions alternately onto each skewer.",
                        "Preheat barbecue to a medium heat.",
                        "Cook for 3-5 minutes on each side or until cooked through. Serve immediately."
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
                    Serves = 4,
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "400g lamb leg steaks, thinly sliced" },
                        new Ingredient { Name = "3 tsp garam masala" },
                        new Ingredient { Name = "Salt and pepper, to season" },
                        new Ingredient { Name = "4 naan breads" },
                        new Ingredient { Name = "&frac12; cup sweet mango chutney, plus &frac14; cup extra, to serve" },
                        new Ingredient { Name = "1&frac12; cups grated cheddar or pizza cheese" },
                        new Ingredient { Name = "1 green capsicum, thinly sliced" },
                        new Ingredient { Name = "2 lebanese cucumbers, peeled into long, thin ribbons" },
                        new Ingredient { Name = "&frac12; cup natural yoghurt" },
                        new Ingredient { Name = "&frac12; cup mint leaves, torn" },
                        new Ingredient { Name = "Mixed salad, to serve" }
                    },
                    Method = new List<string>
                    {
                        "Preheat an oven grill to high",
                        "Combine lamb and garam masala in a medium bowl, season.",
                        "Line 2 large baking trays with baking paper.",
                        "Place 2 naan breads on each baking tray.",
                        "Spread each naan with even amounts of mango chutney, top with cheese, capsicum and lamb mixture.",
                        "In 2 separate batches, grill the naan breads for 4-5 minutes, or until golden and the lamb is just cooked.",
                        "Top pizzas with cucumber, dollops of yoghurt, half the extra chutney and mint. Serve with remaining chutney and salad on the side.",
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
                    Serves = 12,
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "1&frac12; cups sushi rice" },
                        new Ingredient { Name = "1&frac12; cups water, plus extra for rinsing" },
                        new Ingredient { Name = "&frac14 cup sushi vinegar" },
                        new Ingredient { Name = "3 sheets nori seaweed" },
                        new Ingredient { Name = "1 lebanese cucumber, thinly sliced" },
                        new Ingredient { Name = "210g can pink salmon, drained, flaked" }
                    },
                    Method = new List<string>
                    {
                        "Rinse rice in cold water until water runs clear. Drain.",
                        "Place in a medium sized saucepan with 1&frac12; cups of water. Bring to the boil, stirring.",
                        "Reduce heat and cover. Simmer for 12 minutes, or until water is absorbed.",
                        "Remove from heat. Stand for 5 minutes without removing lid",
                        "Drain rice, then spread evenly into a baking dish.",
                        "Drizzle sushi vinegar over the hot rice.",
                        "Using a flat spatula, slice through the rice to mix the vinegar through.",
                        "Cover with a damp tea towel. Set aside to cool.",
                        "Line a 20 x 30cm slice pan with plastic food wrap, extending wrap over the sides.",
                        "Cover base with 1&frac12; sheets of the nori.",
                        "Using damp hands, press half the rice evenly over nori and press down gently.",
                        "Cover with plastic food wrap. Chill in the refrigerator for 30 minutes or until firm. Cut to serve."
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
                    Serves = 4,
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "2 tsp vegetable or olive oil" },
                        new Ingredient { Name = "1 Tbsp lemon juice" },
                        new Ingredient { Name = "1 tsp dried oregano" },
                        new Ingredient { Name = "180g haloumi, cut into 8 slices" },
                        new Ingredient { Name = "1 eggplant, cut into 1cm slices" },
                        new Ingredient { Name = "Cooking oil spray" },
                        new Ingredient { Name = "4 wholegrain rolls, halved" },
                        new Ingredient { Name = "2 Tbsp basil pesto" },
                        new Ingredient { Name = "60g baby rocket leaves" },
                        new Ingredient { Name = "2 tomatoes, sliced" }
                    },
                    Method = new List<string>
                    {
                        "Combine oil, lemon juice and oregano in a shallow bowl.",
                        "Add haloumi and gently turn to coat. Set aside for 10 minutes.",
                        "Preheat a barbecue or grill pan to a high heat.",
                        "Spray eggplant with oil and cook for 3 minutes until golden and tender.",
                        "Cook haloumi for 1 minute rach side or until golden.",
                        "Toast cut-side of rolls on the barbecue or grill pan for 30 seconds or until golden.",
                        "Spread each top side of the roll with &frac14; tablespoon pesto.",
                        "Top with &frac14; of the rocket, tomato, haloumi and eggplant, and close.",
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
                    Serves = 4,
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "8 nectarines, halved, stones removed" },
                        new Ingredient { Name = "&frac14; cup brown sugar" },
                        new Ingredient { Name = "2 Tbsp orange juice" },
                        new Ingredient { Name = "1 cup natural yoghurt" },
                        new Ingredient { Name = "2 Tbsp icing sugar, sifted" },
                        new Ingredient { Name = "2 Tbsp passionfruit pulp" },
                    },
                    Method = new List<string>
                    {
                        "Preheat an oven grill to high.",
                        "Line an oven tray with baking paper.",
                        "Place netarines, cut-side up, on the oven tray.",
                        "Sprinkle with brown sugar and drizzle with orange juice.",
                        "Grill for 20 minutes or until lightly browned.",
                        "Combine yoghurt and icing sugar in medium bowl. Swirl through in the passionfruit pulp.",
                        "Serve nectarines with yoghurt on the side."
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
                    Serves = 4,
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "500g chicken thigh fillets, cut into 2cm cubes" },
                        new Ingredient { Name = "2 Tbsp olive oil" },
                        new Ingredient { Name = "1 Tbsp Cajun seasoning" },
                        new Ingredient { Name = "250g cherry tomatoes" },
                        new Ingredient { Name = "12 bamboo skewers, soaked in water" },
                        new Ingredient { Name = "1&frac12; cups chicken stock" },
                        new Ingredient { Name = "&frac34; cup long-grain white rice" },
                        new Ingredient { Name = "&frac12; cup frozen peas, thawed" },
                        new Ingredient { Name = "50g baby spinach leaves" }
                    },
                    Method = new List<string>
                    {
                        "In a large bowl combine chicken, oil and Cajun seasoning. Mix well to coat.",
                        "Thread chicken and tomatoes, alternating each, onto 12 skewers. Set aside.",
                        "In a medium saucepan, combine stock and rice.",
                        "Cover and bring to the boil on high, then reduce heat to low.",
                        "Cook, covered for 10-12 minutes, or until rice is just tender and stock absorbed. Remove from heat.",
                        "Stir peas and spinach through.",
                        "Cover again, and set aside for 5 minutes.",
                        "Preheat a grill pan or barbecue to a medium heat. Cook skewers for 10-15 minutes, turning, until cooked through and brown.",
                        "Serve skewers on a bed of the rice."
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
                    Serves = 12,
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "12 paper muffin cases" },
                        new Ingredient { Name = "&frac34; cup cooked macaroni pasta" },
                        new Ingredient { Name = "1 corn cob, kernels removed (&frac12; cup corn kernels)" },
                        new Ingredient { Name = "6 eggs" },
                        new Ingredient { Name = "&frac12; cup cream" },
                        new Ingredient { Name = "&frac12; cup milk" },
                        new Ingredient { Name = "&frac12; cup grated Parmesan" },
                        new Ingredient { Name = "Salt and pepper, to season" },
                        new Ingredient { Name = "&frac14; cup basil pesto" }
                    },
                    Method = new List<string>
                    {
                        "Preheat oven to 180&deg;C (160&deg;C fan-forced).",
                        "Line a 12-hole muffin tray with paper patty cases.",
                        "In a medium bowl, combine cooked pasta corn.",
                        "In a separate bowl, whisk eggs, cream, milk and grated Parmesan together. Season to taste.",
                        "Divide combined pasta and corn mixture equally between each case.",
                        "Pour egg mixture on top, then add a dollop of pesto.",
                        "Bake for 20-25 minutes, or until just set.",
                        "Leave to cool in the pan for 5 minutes before removing. Serve warm or cold."
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
                    Serves = 4,
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "175g dried rice vermicelli noodles" },
                        new Ingredient { Name = "2 tsp vegetable or peanut oil" },
                        new Ingredient { Name = "1 spring onion, finely chopped" },
                        new Ingredient { Name = "3 celery sticks, finely chopped" },
                        new Ingredient { Name = "1 long red chilli, seeded, finely chopped" },
                        new Ingredient { Name = "3 tsp finely grated fresh ginger" },
                        new Ingredient { Name = "500g chicken mince" },
                        new Ingredient { Name = "250g green beans, trimmed, cut into 3cm lengths" },
                        new Ingredient { Name = "1&frac12; Tbsp lemon or lime juice" },
                        new Ingredient { Name = "1&frac12; Tbsp fish sauce" },
                        new Ingredient { Name = "2 tsp brown sugar" },
                        new Ingredient { Name = "12 iceberg lettuce leaves" },
                        new Ingredient { Name = "Coriander leaves, to garnish" }
                    },
                    Method = new List<string>
                    {
                        "Soak noodles in a large heatproof bowl of boiling water for 5 minutes.",
                        "Stir to separate strands, then drain. Using kitchen scissors, snip into shorter lengths.",
                        "Meanwhile, heat a wok or large frying pan over a high heat.",
                        "Add oil and swirl to coat the surface. Add spring onion and celery, and stir-fry for 2 minutes or until golden.",
                        "Add chilli and ginger, and stir-fry for 1 minute more.",
                        "Add mince and cook for 5 minutes or until browned.",
                        "Add beans and stir-fry for 2 minutes or until beans are tender.",
                        "Add lemon or lime juice, fish sauce and sugar, and stir-fry for 1-2 minutes or until combined. Stir in noodles.",
                        "Place lettuce cups on plates. Fill with chicken mixture. Sprinkle with coriander and serve."
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

        public async Task<RecipeDetails> GetRecipeAsync(long id)
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