using BookInventory.Version02.Models;
using System.Web.Mvc;

namespace BookInventory.Version02.Controllers
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
            return View(book);
        }
    }
}