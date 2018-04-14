using System;
using System.Collections.Generic;

namespace RecipeList.Web
{
    public class Recipe
    {
        public string Name;
        public User CreatedBy;
        public int Serves;
        public List<Ingredient> Ingredients;
        public List<string> Method;
    }
}