using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FamilyRecipes.Models
{
    public class IngredientMeasurement
    {
        public RecipeIngredient Ingredient;
        public double Amount;
        public FoodUnit Unit;
        public string Notes;
    }
}