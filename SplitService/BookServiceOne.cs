using Data;
using System.Collections.Generic;
using System.Linq;

namespace SplitService
{
    public class BookServiceOne : IBookServiceOne
    {
        public List<Book> GetAll()
        {
            var service = new Service.BookService();
            return service.GetAll().OrderBy(b => b.Name).ToList();
        }
    }
}