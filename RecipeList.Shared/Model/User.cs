using System;
using System.Collections.Generic;

namespace RecipeList.Model
{
    public class User
    {
        public string FirstName;
        public string LastName;

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}