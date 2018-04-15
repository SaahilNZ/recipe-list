using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace RecipeList.Model
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [JsonIgnore]
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}