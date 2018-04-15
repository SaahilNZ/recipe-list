using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RecipeList.Services.Exceptions
{
    public class RecipeNotFoundException : Exception
    {
        public long RecipeId { get; private set; }

        public RecipeNotFoundException(long recipeId)
            : base($"A recipe with Id {recipeId} does not exist.")
        {
            RecipeId = recipeId;
        }
    }
}