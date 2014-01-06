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
	}
}