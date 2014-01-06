using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FamilyRecipes.Models
{
    public class RecipeIngredient
    {
        public RecipeIngredient() { }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}