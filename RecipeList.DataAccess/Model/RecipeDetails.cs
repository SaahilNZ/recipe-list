using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace RecipeList.Model
{
    public class RecipeDetails
    {
        [Key]
        public long RecipeId { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Range(1, int.MaxValue)]
        [Required]
        public int Serves { get; set; }
        
        public List<Ingredient> Ingredients { get; set; }
        public List<Step> Method { get; set; }
        
        [JsonIgnore]
        public long UserId { get; set; }
        public User User { get; set; }
    }
}