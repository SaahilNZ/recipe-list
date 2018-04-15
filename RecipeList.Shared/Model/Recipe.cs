using System;
using System.Collections.Generic;

namespace RecipeList.Model
{
    public class Recipe
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public User CreatedBy { get; set; }
    }
}