using FamilyRecipes.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FamilyRecipes.Stroage
{
    public class IngredientManager
    {
        private static IngredientManager _Instance;

        public static IngredientManager Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new IngredientManager();
                }
                return _Instance;
            }
        }

        private string filename = "ingredients.json";
        private Dictionary<string, RecipeIngredient> Ingredients;

        public IngredientManager()
        {
            LoadFromDisk();
        }

        public IEnumerable<RecipeIngredient> GetIngredients()
        {
            return Ingredients.Values;
        }

        public RecipeIngredient GetIngredient(string id)
        {
            return Ingredients[id];
        }

        public void ProcessIngredient (RecipeIngredient ingredient)
        {
            Ingredients[ingredient.Id] = ingredient;
            SaveToDisk();
        }

        public string NextId()
        {
            return "" + Ingredients.Count;
        }

        private void LoadFromDisk()
        {
            var path = getStorePath();
            var json = System.IO.File.ReadAllText(path);
            Ingredients = JsonConvert.DeserializeObject<Dictionary<string, RecipeIngredient>>(json);
        }

        private void SaveToDisk()
        {
            string json = JsonConvert.SerializeObject(Ingredients);
            var path = getStorePath();
            System.IO.File.WriteAllText(path, json);
        }

        private string getStorePath()
        {
            return HttpContext.Current.Server.MapPath("~/App_Data/" + filename);
        }
    }
}