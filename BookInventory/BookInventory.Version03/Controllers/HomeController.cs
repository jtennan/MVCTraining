using BookInventory.Version03.Models;
using System.Web.Mvc;

namespace BookInventory.Version03.Controllers
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
}