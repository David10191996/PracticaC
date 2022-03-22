using BiblioNetAPP.Models;
using BiblioNetAPP.Services;
using Microsoft.AspNetCore.Mvc;

namespace BiblioNetAPP.Controllers
{
    public class BookController : Controller
    {
        private readonly IRepositorieBook repositorieBook;

        public BookController(IRepositorieBook repositoriesBook)
        {
            this.repositorieBook = repositoriesBook;
        }
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
            /*book.Cant= 10;
            book.Price = 1234;
            book.Author= 2;
            book.Gender = 4;
            book.Editorial = 6;*/
            repositorieBook.RegisterBook(book);
            return View();
        }
    }
}
