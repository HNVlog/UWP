using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T2010A_WAD.Models;

namespace T2010A_WAD.Controllers
{
    public class CategoriesController : Controller
    {
        private DataContext context = new DataContext();
        // GET: Categories
        public ActionResult Index()
        {
            ViewData["Page-Title"] = "Categories page";
            ViewBag.PageTitle = "Demo Title for categories Page";
            // var category = new Category() { Id = 1, CategoriesName = "Fashion" };
            // ViewBag.Category = category;
            var list = context.Categories.ToList();
            return View(list); //passing data by model
        }
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult UpdateCategory()
        {
            return View();
        }
        public ActionResult DeleteCategory()
        {
            return View();
        }
    }
}