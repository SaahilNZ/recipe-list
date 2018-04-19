using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeList.Model
{
    public class Step
    {
        public long StepId { get; set; }
        
        [Required]
        public long StepNumber { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        public long RecipeId { get; set; }
        public RecipeDetails Recipe { get; set; }
    }
}