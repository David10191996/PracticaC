using BiblioNetAPP.Models;
using Microsoft.AspNetCore.Mvc;

namespace BiblioNetAPP.Controllers
{
    public class BookController : Controller
    {
        public IActionResult RegisterBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterBook(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }
            return View();
        }
    }
}
