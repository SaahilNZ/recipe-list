using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace RecipeList.Model
{
    public class Recipe
    {
        public long RecipeId { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [JsonIgnore]
        public long UserId { get; set; }

        [Display(Name = "Created by")]
        public User User { get; set; }
    }
}