using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace RecipeList.Model
{
    public class User
    {
        public long UserId { get; set; }

        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }

        [JsonIgnore]
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}