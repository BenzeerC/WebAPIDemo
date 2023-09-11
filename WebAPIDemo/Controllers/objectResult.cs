using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Entites;

namespace WebAPIDemo.Controllers
{
    internal class objectResult : IActionResult
    {
        private IEnumerable<Book> enumerable;
        private Book book;

        public objectResult(IEnumerable<Book> enumerable)
        {
            this.enumerable = enumerable;
        }

        public objectResult(Book book)
        {
            this.book = book;
        }
    }
}