

namespace HomeWork3.task1
{
    public class Library
    {
        private List<Book> _books = new List<Book>();

        public Library() { }

        public Library(List<Book> books) { this._books = books; }

        public List<Book> Books { get { return _books; } set { _books = value; } }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }
        public bool BorrowBook(string title)
        {
            foreach (Book book in _books)
            {
                if (book.Title == title)
                {
                    book.IsAvailable = false;
                    Console.WriteLine($"Book {title} is borrowed.");
                    return true;
                }
            }
            Console.WriteLine($"Book {title} not found!");
            return false;

        }
        public bool ReturnBook(string title)
        {
         
            foreach (Book book in _books)
            {
                if (book.Title == title)
                {
                    book.IsAvailable = true;
                    Console.WriteLine($"Book {title} is returned.");
                    return true;
                }
            }
            Console.WriteLine($"Book {title} not found!");
            return false;
        }
        public void printList() 
        {
            foreach (Book book in _books)
                Console.WriteLine(book);
        }


    }
}
