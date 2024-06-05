using MyHelperClassLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12___05._06._2024
{
    public class Book
    {
        private static int _counter;
        public int Id { get; set; }
        public string Name {  get; set; }
        public string AuthorName { get; set; }
        public int PageCount {  get; set; }

        public string Code { get; set; }

        static Book()
        {
            _counter = 0;
        }
        public Book(string name, string authorName, int pageCount)
        {
            _counter++;
            Id = _counter;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            Code = MyHelperClassLibrary.Helpers.Helper.CreateBookCode(Name, Id);
        }

        public override string ToString()
        {
            return $"Book: {Name}\nAuthor: {AuthorName}\nPage Count: {PageCount}\nCode: {Code}\n\n";
        }

    }
    
}
