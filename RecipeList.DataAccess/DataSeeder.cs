using Microsoft.EntityFrameworkCore;
using RecipeList.Model;
using System.Collections.Generic;

namespace RecipeList.DataAccess
{
    public static class DataSeeder
    {
        public static void PopulateSeedData(this RecipesContext context)
        {
            var user1 = new User
            {
                FirstName = "John",
                LastName = "Doe"
            };
            context.Users.Add(user1);
            var ingredients1 = new List<Ingredient>
            {
                new Ingredient { Name = "1&frac12; sheets frozen puff pastry, thawed" },
                new Ingredient { Name = "Spray cooking oil" },
                new Ingredient { Name = "250g baby spinach" },
                new Ingredient { Name = "100g crumbled feta cheese" }
            };
            context.Ingredients.AddRange(ingredients1);
            var method1 = new List<Step>
            {
                new Step { StepNumber = 1, Description = "Preheat oven to 200&deg;C (180&deg;C fan-forced)." },
                new Step { StepNumber = 2, Description = "Line a large oven tray with baking paper." },
                new Step { StepNumber = 3, Description = "Join pastry sheets, overlapping them by 1cm and pressing together to join." },
                new Step { StepNumber = 4, Description = "Place pastry over the baking paper." },
                new Step { StepNumber = 5, Description = "Spray a medium sized frying pan with oil." },
                new Step { StepNumber = 6, Description = "Place spinach in the frying pan and saut&eacute; over a medium heat for 1-2 minutes, or until just wilted." },
                new Step { StepNumber = 7, Description = "Transfer to a colander and squeeze out excess moisture." },
                new Step { StepNumber = 8, Description = "Spread spinach over pastry, leaving a 3cm border around the edge." },
                new Step { StepNumber = 9, Description = "Sprinkle feta over top." },
                new Step { StepNumber = 10, Description = "Brush pastry edge with a small amount of water and roll up loosely." },
                new Step { StepNumber = 11, Description = "Cut into six equal rounds." },
                new Step { StepNumber = 12, Description = "Arrange the rounds with the cut-side up on the baking tray." },
                new Step { StepNumber = 13, Description = "Bake for 15-20 minutes or until the pastry is crisp and golden." }
            };
            context.RecipeSteps.AddRange(method1);

            var user2 = new User
            {
                FirstName = "Jane",
                LastName = "Doe"
            };
            context.Users.Add(user2);
            var ingredients2 = new List<Ingredient>
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
            };
            context.Ingredients.AddRange(ingredients2);
            var method2 = new List<Step>
            {
                new Step { StepNumber = 1, Description = "In a large bowl, combine zests, juices, oil, garlic, honey and pepper." },
                new Step { StepNumber = 2, Description = "Add prawns, turning to coat. Leave to marinate for at least 10 minutes." },
                new Step { StepNumber = 3, Description = "Thread prawns, peach pieces and spring onions alternately onto each skewer." },
                new Step { StepNumber = 4, Description = "Preheat barbecue to a medium heat." },
                new Step { StepNumber = 5, Description = "Cook for 3-5 minutes on each side or until cooked through. Serve immediately." }
            };
            context.RecipeSteps.AddRange(method2);

            var user3 = new User
            {
                FirstName = "James",
                LastName = "Dough"
            };
            context.Users.Add(user3);
            var ingredients3 = new List<Ingredient>
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
            };
            context.Ingredients.AddRange(ingredients3);
            var method3 = new List<Step>
            {
                new Step { StepNumber = 1, Description = "Preheat an oven grill to high" },
                new Step { StepNumber = 2, Description = "Combine lamb and garam masala in a medium bowl, season." },
                new Step { StepNumber = 3, Description = "Line 2 large baking trays with baking paper." },
                new Step { StepNumber = 4, Description = "Place 2 naan breads on each baking tray." },
                new Step { StepNumber = 5, Description = "Spread each naan with even amounts of mango chutney, top with cheese, capsicum and lamb mixture." },
                new Step { StepNumber = 6, Description = "In 2 separate batches, grill the naan breads for 4-5 minutes, or until golden and the lamb is just cooked." },
                new Step { StepNumber = 7, Description = "Top pizzas with cucumber, dollops of yoghurt, half the extra chutney and mint. Serve with remaining chutney and salad on the side." }
            };
            context.RecipeSteps.AddRange(method3);

            var user4 = new User
            {
                FirstName = "Jimmy",
                LastName = "Doe"
            };
            context.Users.Add(user4);
            var ingredients4 = new List<Ingredient>
            {
                new Ingredient { Name = "1&frac12; cups sushi rice" },
                new Ingredient { Name = "1&frac12; cups water, plus extra for rinsing" },
                new Ingredient { Name = "&frac14 cup sushi vinegar" },
                new Ingredient { Name = "3 sheets nori seaweed" },
                new Ingredient { Name = "1 lebanese cucumber, thinly sliced" },
                new Ingredient { Name = "210g can pink salmon, drained, flaked" }
            };
            context.Ingredients.AddRange(ingredients4);
            var method4 = new List<Step>
            {
                new Step { StepNumber = 1, Description = "Rinse rice in cold water until water runs clear. Drain." },
                new Step { StepNumber = 2, Description = "Place in a medium sized saucepan with 1&frac12; cups of water. Bring to the boil, stirring." },
                new Step { StepNumber = 3, Description = "Reduce heat and cover. Simmer for 12 minutes, or until water is absorbed." },
                new Step { StepNumber = 4, Description = "Remove from heat. Stand for 5 minutes without removing lid" },
                new Step { StepNumber = 5, Description = "Drain rice, then spread evenly into a baking dish." },
                new Step { StepNumber = 6, Description = "Drizzle sushi vinegar over the hot rice." },
                new Step { StepNumber = 7, Description = "Using a flat spatula, slice through the rice to mix the vinegar through." },
                new Step { StepNumber = 8, Description = "Cover with a damp tea towel. Set aside to cool." },
                new Step { StepNumber = 9, Description = "Line a 20 x 30cm slice pan with plastic food wrap, extending wrap over the sides." },
                new Step { StepNumber = 10, Description = "Cover base with 1&frac12; sheets of the nori." },
                new Step { StepNumber = 11, Description = "Using damp hands, press half the rice evenly over nori and press down gently." },
                new Step { StepNumber = 12, Description = "Cover with plastic food wrap. Chill in the refrigerator for 30 minutes or until firm. Cut to serve." }
            };
            context.RecipeSteps.AddRange(method4);

            var user5 = new User
            {
                FirstName = "Janette",
                LastName = "Doe"
            };
            context.Users.Add(user5);
            var ingredients5 = new List<Ingredient>
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
            };
            context.Ingredients.AddRange(ingredients5);
            var method5 = new List<Step>
            {
                new Step { StepNumber = 1, Description = "Combine oil, lemon juice and oregano in a shallow bowl." },
                new Step { StepNumber = 2, Description = "Add haloumi and gently turn to coat. Set aside for 10 minutes." },
                new Step { StepNumber = 3, Description = "Preheat a barbecue or grill pan to a high heat." },
                new Step { StepNumber = 4, Description = "Spray eggplant with oil and cook for 3 minutes until golden and tender." },
                new Step { StepNumber = 5, Description = "Cook haloumi for 1 minute rach side or until golden." },
                new Step { StepNumber = 6, Description = "Toast cut-side of rolls on the barbecue or grill pan for 30 seconds or until golden." },
                new Step { StepNumber = 7, Description = "Spread each top side of the roll with &frac14; tablespoon pesto." },
                new Step { StepNumber = 8, Description = "Top with &frac14; of the rocket, tomato, haloumi and eggplant, and close." }
            };
            context.RecipeSteps.AddRange(method5);

            var user6 = new User
            {
                FirstName = "Jack",
                LastName = "Doe"
            };
            context.Users.Add(user6);
            var ingredients6 = new List<Ingredient>
            {
                new Ingredient { Name = "8 nectarines, halved, stones removed" },
                new Ingredient { Name = "&frac14; cup brown sugar" },
                new Ingredient { Name = "2 Tbsp orange juice" },
                new Ingredient { Name = "1 cup natural yoghurt" },
                new Ingredient { Name = "2 Tbsp icing sugar, sifted" },
                new Ingredient { Name = "2 Tbsp passionfruit pulp" },
            };
            context.Ingredients.AddRange(ingredients6);
            var method6 = new List<Step>
            {
                new Step { StepNumber = 1, Description = "Preheat an oven grill to high." },
                new Step { StepNumber = 2, Description = "Line an oven tray with baking paper." },
                new Step { StepNumber = 3, Description = "Place netarines, cut-side up, on the oven tray." },
                new Step { StepNumber = 4, Description = "Sprinkle with brown sugar and drizzle with orange juice." },
                new Step { StepNumber = 5, Description = "Grill for 20 minutes or until lightly browned." },
                new Step { StepNumber = 6, Description = "Combine yoghurt and icing sugar in medium bowl. Swirl through in the passionfruit pulp." },
                new Step { StepNumber = 7, Description = "Serve nectarines with yoghurt on the side." }
            };
            context.RecipeSteps.AddRange(method6);

            var user7 = new User
            {
                FirstName = "Josh",
                LastName = "Doe"
            };
            context.Users.Add(user7);
            var ingredients7 = new List<Ingredient>
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
            };
            context.Ingredients.AddRange(ingredients7);
            var method7 = new List<Step>
            {
                new Step { StepNumber = 1, Description = "In a large bowl combine chicken, oil and Cajun seasoning. Mix well to coat." },
                new Step { StepNumber = 2, Description = "Thread chicken and tomatoes, alternating each, onto 12 skewers. Set aside." },
                new Step { StepNumber = 3, Description = "In a medium saucepan, combine stock and rice." },
                new Step { StepNumber = 4, Description = "Cover and bring to the boil on high, then reduce heat to low." },
                new Step { StepNumber = 5, Description = "Cook, covered for 10-12 minutes, or until rice is just tender and stock absorbed. Remove from heat." },
                new Step { StepNumber = 6, Description = "Stir peas and spinach through." },
                new Step { StepNumber = 7, Description = "Cover again, and set aside for 5 minutes." },
                new Step { StepNumber = 8, Description = "Preheat a grill pan or barbecue to a medium heat. Cook skewers for 10-15 minutes, turning, until cooked through and brown." },
                new Step { StepNumber = 9, Description = "Serve skewers on a bed of the rice." }
            };
            context.RecipeSteps.AddRange(method7);

            var user8 = new User
            {
                FirstName = "Jill",
                LastName = "Doe"
            };
            context.Users.Add(user8);
            var ingredients8 = new List<Ingredient>
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
            };
            context.Ingredients.AddRange(ingredients8);
            var method8 = new List<Step>
            {
                new Step { StepNumber = 1, Description = "Preheat oven to 180&deg;C (160&deg;C fan-forced)." },
                new Step { StepNumber = 2, Description = "Line a 12-hole muffin tray with paper patty cases." },
                new Step { StepNumber = 3, Description = "In a medium bowl, combine cooked pasta corn." },
                new Step { StepNumber = 4, Description = "In a separate bowl, whisk eggs, cream, milk and grated Parmesan together. Season to taste." },
                new Step { StepNumber = 5, Description = "Divide combined pasta and corn mixture equally between each case." },
                new Step { StepNumber = 6, Description = "Pour egg mixture on top, then add a dollop of pesto." },
                new Step { StepNumber = 7, Description = "Bake for 20-25 minutes, or until just set." },
                new Step { StepNumber = 8, Description = "Leave to cool in the pan for 5 minutes before removing. Serve warm or cold." }
            };
            context.RecipeSteps.AddRange(method8);

            var user9 = new User
            {
                FirstName = "Jerry",
                LastName = "Doe"
            };
            context.Users.Add(user9);
            var ingredients9 = new List<Ingredient>
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
            };
            context.Ingredients.AddRange(ingredients9);
            var method9 = new List<Step>
            {
                new Step { StepNumber = 1, Description = "Soak noodles in a large heatproof bowl of boiling water for 5 minutes." },
                new Step { StepNumber = 2, Description = "Stir to separate strands, then drain. Using kitchen scissors, snip into shorter lengths." },
                new Step { StepNumber = 3, Description = "Meanwhile, heat a wok or large frying pan over a high heat." },
                new Step { StepNumber = 4, Description = "Add oil and swirl to coat the surface. Add spring onion and celery, and stir-fry for 2 minutes or until golden." },
                new Step { StepNumber = 5, Description = "Add chilli and ginger, and stir-fry for 1 minute more." },
                new Step { StepNumber = 6, Description = "Add mince and cook for 5 minutes or until browned." },
                new Step { StepNumber = 7, Description = "Add beans and stir-fry for 2 minutes or until beans are tender." },
                new Step { StepNumber = 8, Description = "Add lemon or lime juice, fish sauce and sugar, and stir-fry for 1-2 minutes or until combined. Stir in noodles." },
                new Step { StepNumber = 9, Description = "Place lettuce cups on plates. Fill with chicken mixture. Sprinkle with coriander and serve." }
            };
            context.RecipeSteps.AddRange(method9);

            var recipes = new List<RecipeDetails>
            {
                new RecipeDetails
                {
                    Name = "Spinach and Feta Scrolls",
                    Serves = 6,
                    Ingredients = ingredients1,
                    Method = method1,
                    User = user1
                },
                new RecipeDetails
                {
                    Name = "Barbecue Prawn and Peach Skewers",
                    Serves = 8,
                    Ingredients = ingredients2,
                    Method = method2,
                    User = user2
                },
                new RecipeDetails
                {
                    Name = "Lamb Naan Pizzas",
                    Serves = 4,
                    Ingredients = ingredients3,
                    Method = method3,
                    User = user3
                },
                new RecipeDetails
                {
                    Name = "Salmon and Cucumber Sushi Slice",
                    Serves = 12,
                    Ingredients = ingredients4,
                    Method = method4,
                    User = user4
                },
                new RecipeDetails
                {
                    Name = "BBQ Eggplant, Haloumi and Pesto Burgers",
                    Serves = 4,
                    Ingredients = ingredients5,
                    Method = method5,
                    User = user5
                },
                new RecipeDetails
                {
                    Name = "Grilled Nectarines with Passionfruit Yoghurt",
                    Serves = 4,
                    Ingredients = ingredients6,
                    Method = method6,
                    User = user6
                },
                new RecipeDetails
                {
                    Name = "Tomato and Cajun Chicken Skewers with Green Rice",
                    Serves = 4,
                    Ingredients = ingredients7,
                    Method = method7,
                    User = user7
                },
                new RecipeDetails
                {
                    Name = "Pasta and Corn Frittatas",
                    Serves = 12,
                    Ingredients = ingredients8,
                    Method = method8,
                    User = user8
                },
                new RecipeDetails
                {
                    Name = "Chicken and Noodle Lettuce Cups",
                    Serves = 4,
                    Ingredients = ingredients9,
                    Method = method9,
                    User = user9
                }
            };
            context.Recipes.AddRange(recipes);
            context.SaveChanges();
        }
    }
}