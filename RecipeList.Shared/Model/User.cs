using System;
using System.Collections.Generic;

namespace RecipeList.Model
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}