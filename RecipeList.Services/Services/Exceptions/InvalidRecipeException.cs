using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RecipeList.Services.Exceptions
{
    public class InvalidRecipeException : Exception
    {
        [Flags]
        public enum Reason
        {
            None = 0,
            NullRecipe = 1,
            NoIngredients = 2,
            NoMethodSteps = 4,
            NoUser = 8
        }

        public Reason Reasons { get; private set; }
        
        /// <summary>
        ///  Creates an InvalidRecipeException for when the recipe is null.
        /// </summary>
        public InvalidRecipeException()
            : base("The specified recipe is invalid")
        {
            Reasons = Reason.NullRecipe;
        }
        
        /// <summary>
        ///  Creates an InvalidRecipeException for when one or more properties of the recipe are null.
        /// </summary>
        public InvalidRecipeException(Reason reasons)
            : base("The specified recipe is invalid.")
        {
            Reasons = reasons;
        }
    }
}