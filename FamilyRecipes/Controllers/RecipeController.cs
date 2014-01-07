using FamilyRecipes.Models;
using FamilyRecipes.Stroage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FamilyRecipes.Controllers
{
    public class RecipeController : Controller
    {
        //
        // GET: /Recipe/
        public ActionResult Index()
        {
            var recipes = RecipeManager.Instance.GetRecipes();
            return View(recipes);
        }

        public ActionResult Create()
        {
            var newRecipe = new Recipe
            {
                Ingredients = new List<IngredientMeasurement>()
            };
            return View(newRecipe);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                recipe.Id = RecipeManager._Instance.NextId();
                RecipeManager._Instance.ProcessRecipe(recipe);
                return RedirectToAction("Index");
            }
            return View(recipe);
        }

        public ActionResult BlankIngredientRow()
        {
            return PartialView("IngredientEditorRow", new IngredientMeasurement());
        }
	}
}