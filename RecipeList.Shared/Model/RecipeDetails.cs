using System;
using System.Collections.Generic;

namespace RecipeList.Model
{
    public class RecipeDetails
    {
        public int Id;
        public string Name;
        public User CreatedBy;
        public int Serves;
        public List<Ingredient> Ingredients;
        public List<string> Method;
    }
}