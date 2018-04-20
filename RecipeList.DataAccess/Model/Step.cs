using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace RecipeList.Model
{
    public class Step
    {
        public long StepId { get; set; }
        
        [Required]
        public long StepNumber { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        [JsonIgnore]
        public long RecipeId { get; set; }
        [JsonIgnore]
        public RecipeDetails Recipe { get; set; }
    }
}