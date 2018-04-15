using System;
using System.Collections.Generic;

namespace RecipeList.Model
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User CreatedBy { get; set; }
    }
}