namespace advancedC_3
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }

        public Book(string title, string author, string isbn, DateTime publicationDate)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationDate = publicationDate;
        }
    }
    // 4. User-Defined Delegate
    public delegate string BookDelegate(Book b);
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of books
            List<Book> books = new List<Book>
        {
            new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565", new DateTime(1925, 4, 10)),
            new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084", new DateTime(1960, 7, 11)),
            new Book("1984", "George Orwell", "9780451524935", new DateTime(1949, 6, 8))
        };

            // a. User-Defined Delegate
            Console.WriteLine("Using User-Defined Delegate (GetTitle):");
            BookDelegate fPtr1 = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks(books, new Func<Book, string>(fPtr1));

            // b. BCL Delegate
            Console.WriteLine("\nUsing BCL Delegate (GetAuthor):");
            Func<Book, string> fPtr2 = BookFunctions.GetAuthor;
            LibraryEngine.ProcessBooks(books, fPtr2);

            // c. Anonymous Method (GetISBN)
            Console.WriteLine("\nUsing Anonymous Method (GetISBN):");
            Func<Book, string> fPtr3 = delegate (Book b) { return b.ISBN; };
            LibraryEngine.ProcessBooks(books, fPtr3);

            // d. Lambda Expression (GetPublicationDate)
            Console.WriteLine("\nUsing Lambda Expression (GetPublicationDate):");
            Func<Book, DateTime> fPtr4 = b => b.PublicationDate;
            LibraryEngine.ProcessBooks(books, b => fPtr4(b).ToShortDateString());
        }
    }
}
