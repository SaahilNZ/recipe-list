using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace RecipeList.Model
{
    public class Ingredient
    {
        public long IngredientId { get; set; }
        
        [Required]
        public string Name { get; set; }

        [JsonIgnore]
        public long RecipeId { get; set; }
        [JsonIgnore]
        public RecipeDetails Recipe { get; set; }
    }
}