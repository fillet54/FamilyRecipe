using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FamilyRecipes.Models
{
    public class Recipe
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Introduction { get; set; }
        public List<IngredientMeasurement> Ingredients { get; set; }
        public List<RecipeStep> Steps { get; set; }
    }
}