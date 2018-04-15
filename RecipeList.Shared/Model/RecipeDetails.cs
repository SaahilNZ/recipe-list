using System;
using System.Collections.Generic;

namespace RecipeList.Model
{
    public class RecipeDetails
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public User CreatedBy { get; set; }
        public int Serves { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<string> Method { get; set; }
    }
}