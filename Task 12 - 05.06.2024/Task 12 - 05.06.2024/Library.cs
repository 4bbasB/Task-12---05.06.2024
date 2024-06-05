using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Task_12___05._06._2024
{
    public class Library
    {
        private List<Book> Books = [];

        public Book this[int index]
        {
            get => Books[index];
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public List<Book> FindAllBooksByName(string value)
        {
            var wantedBook = Books.FindAll(book => book.Name.ToLower().Contains(value.Trim().ToLower()));
            if (wantedBook != null)
                return wantedBook;
            else
                throw new NullReferenceException("Code can not Found!");
            return Books.FindAll(book => book.Name.ToLower().Contains(value.Trim().ToLower()));
        }

        public Book? FindBookByCode(string code)
        {
            var wantedBook = Books.Find(book => book.Code.ToLower() == code.Trim().ToLower());
            if (wantedBook != null)
                return wantedBook;
            else
                throw new NullReferenceException("Code can not Found!");
        }
        public void RemoveAllBooksByName(string value)
        {
            Books.RemoveAll(book => book.Name.ToLower().Contains(value.Trim().ToLower()));
        }

        public void RemoveBookByCode(string value)
        {
            if (FindBookByCode(value) != null)
                Books.Remove(FindBookByCode(value));
        }

        public List<Book> SearchBooks(string value)
        {
            value = value.Trim().ToLower();

            return Books.FindAll(book => book.Name.ToLower().Contains(value) ||
                book.AuthorName.ToLower().Contains(value) ||
                book.PageCount.ToString().Contains(value));
        }

        public List<Book> FindAllBooksByPageCountRange(int minPageCount, int maxPageCount)
        {
            return Books.FindAll(book => book.PageCount >= minPageCount && book.PageCount <= maxPageCount);
        }




    }
}
