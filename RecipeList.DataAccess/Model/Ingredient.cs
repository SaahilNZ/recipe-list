using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeList.Model
{
    public class Ingredient
    {
        public long IngredientId { get; set; }
        
        [Required]
        public string Name { get; set; }

        public long RecipeId { get; set; }
        public RecipeDetails Recipe { get; set; }
    }
}