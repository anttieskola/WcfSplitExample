using Data;
using System.Collections.Generic;

namespace Service
{
    public class BookService
    {
        public List<Book> GetAll()
        {
            return new List<Book>
            {
                new Book
                {
                    Name = "One",
                    Pages = new List<Page>
                    {
                        new Page
                        {
                            Content = "1"
                        },
                    }
                },
                new Book
                {
                    Name = "Two",
                    Pages = new List<Page>
                    {
                        new Page
                        {
                            Content = "2"
                        },
                    }
                },
                new Book
                {
                    Name = "Three",
                    Pages = new List<Page>
                    {
                        new Page
                        {
                            Content = "3"
                        },
                    }
                },
            };
        }
    }
}