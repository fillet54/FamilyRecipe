using FamilyRecipes.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FamilyRecipes.Stroage
{
    public class RecipeManager
    {
        public static RecipeManager _Instance;
        public static RecipeManager Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new RecipeManager();
                }
                return _Instance;
            }
        }

        public RecipeManager()
        {
            LoadFromDisk();
        }

        private void LoadFromDisk()
        {
            var path = HttpContext.Current.Server.MapPath("~/App_Data/recipes.json");
            var json = System.IO.File.ReadAllText(path);
            Recipes = JsonConvert.DeserializeObject<Dictionary<string, Recipe>>(json);
        }

        private void SaveToDisk()
        {
            string json = JsonConvert.SerializeObject(Recipes);
            var path = HttpContext.Current.Server.MapPath("~/App_Data/recipes.json");
            System.IO.File.WriteAllText(path, json);
        }

        private Dictionary<string, Recipe> Recipes;

        public IEnumerable<Recipe> GetRecipes()
        {
            return Recipes.Values;
        }

        public Recipe GetRecipe(string id)
        {
            return Recipes[id];
        }
    }
}