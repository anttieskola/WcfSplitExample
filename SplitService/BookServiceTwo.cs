using Data;
using System.Collections.Generic;
using System.Linq;

namespace SplitService
{
    public class BookServiceTwo : IBookServiceTwo
    {
        public List<Book> GetAll()
        {
            var service = new Service.BookService();
            return service.GetAll().OrderByDescending(b => b.Name).ToList();
        }
    }
}