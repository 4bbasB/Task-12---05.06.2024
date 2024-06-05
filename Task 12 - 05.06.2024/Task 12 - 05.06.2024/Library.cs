using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12___05._06._2024
{
    public class Library
    {
        private Book[] _books;

        public Library() 
        { 
            _books = Array.Empty<Book>();
        }


        public void AddBook(Book book) 
        { 
            Array.Resize(ref _books, _books.Length);
            _books[^1] = book;
        }


        public Book[] FindAllBooksByName() { }



        public Book? FindBookByCode(string code) 
        {
            foreach (Book book in _books)
            {
                if (book.Code == code)
                    return book;
            }
            return null;
        }


    }
}
