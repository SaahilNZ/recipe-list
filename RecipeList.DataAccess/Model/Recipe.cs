using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeList.Model
{
    public class Recipe
    {
        public long RecipeId { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public long UserId { get; set; }
    }
}