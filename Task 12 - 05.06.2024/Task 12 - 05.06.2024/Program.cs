namespace Task_12___05._06._2024
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Lupen", "Maurice Leblanc", 469);
            Book book2 = new Book("Hannibal", "Thomas Harris", 469);
            Book book3 = new Book("Tale of Two Cities", "Charles Dickens", 464);
            Book book4 = new Book("The Railway Children", "Edith Nesbit", 72);
            Book book5 = new Book("Chemical Secret", "Tim Vicary", 72);
            Book book6 = new Book("Robinson Crusoe", "Daniel Defoe", 63);
            Book book7 = new Book("Dracula", "Bram Stoker", 95);


            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);
            library.AddBook(book6);
            library.AddBook(book7);


            //Console.WriteLine(library[0].ToString());


            //List<Book> books = library.FindAllBooksByName("Lu").ToList();

            //for (int i = 0; i < books.Count; i++)
            //{
            //    Console.WriteLine(books[i].ToString());
            //}



            //try
            //{
            //    Console.WriteLine(library.FindBookByCode("ro6"));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //List<Book> books = library.SearchBooks("B").ToList();

            //for (int i = 0; i < books.Count; i++)
            //{
            //    Console.WriteLine(books[i].ToString());
            //}



            //library.RemoveAllBooksByName("Lupen");
            //Console.WriteLine(library[0]);



            //library.RemoveBookByCode(book1.Code);
            //Console.WriteLine(library[0]);


            //List<Book> wantedBooks = library.FindAllBooksByPageCountRange(400, 600);
            //foreach (var item in wantedBooks)
            //    Console.WriteLine(item.ToString());
        }
    }
}
