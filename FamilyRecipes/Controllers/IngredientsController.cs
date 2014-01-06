using FamilyRecipes.Models;
using FamilyRecipes.Stroage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FamilyRecipes.Controllers
{
    public class IngredientsController : Controller
    {
        //
        // GET: /Ingredient/
        public ActionResult Index()
        {
            var ingredients = IngredientManager.Instance.GetIngredients();
            return View(ingredients);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RecipeIngredient ingredient)
        {
            if (ModelState.IsValid)
            {
                ingredient.Id = IngredientManager.Instance.NextId();
                IngredientManager.Instance.ProcessIngredient(ingredient);
                return RedirectToAction("Index");
            }
            return View(ingredient);
        }
	}
}