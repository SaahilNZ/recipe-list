using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeList.Model
{
    public class RecipeDetails
    {
        [Key]
        public long RecipeId { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public int Serves { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<Step> Method { get; set; }
        
        public long UserId { get; set; }
        public User User { get; set; }
    }
}