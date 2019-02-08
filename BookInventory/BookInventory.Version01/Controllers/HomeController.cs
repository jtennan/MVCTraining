using BookInventory.Version01.Models;
using System.Web.Mvc;

namespace BookInventory.Version01.Controllers
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