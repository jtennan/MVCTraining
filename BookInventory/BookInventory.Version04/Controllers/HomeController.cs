using BookInventory.Version04.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace BookInventory.Version04.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Book());
        }

        [HttpPost]
        public ActionResult Index(Book book)
        {
            if (ModelState.IsValid)
            {
                // Display success to user
                return RedirectToAction("Success", book);
            }

            return View(book);
        }

        public ActionResult Success(Book book)
        {
            return View(book);
        }
    }

    public static class Blah
    {
        public static MvcHtmlString DropDownListFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,             // The HTML helper instance that this method extends.
            Expression<Func<TModel, TProperty>> expression, // An expression that identifies the object that contains the properties to display.
            IEnumerable<SelectListItem> selectList,         // A collection of SelectListItem objects that are used to populate the drop-down list.
            string optionLabel,                             // The text for a default empty item. This parameter can be null.
            object htmlAttributes)                          // An object that contains the HTML attributes to set for the element.
        {
            return null;
        }
    }
}