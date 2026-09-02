

namespace HomeWork3.task1
{
    public class Library
    {
        private List<Book> _books = new List<Book>();

        public Library() { }

        //public Library(List<Book> books) { this._books = books; }

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
                    if (book.IsAvailable)
                    {
                        book.IsAvailable = false;
                        Console.WriteLine($"Book {title} is borrowed.");
                        return true;
                    }
                    else if (!book.IsAvailable)
                    {
                        Console.WriteLine($"Book {title} is already borrowed.");
                        return false;
                    }
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
                    if (!book.IsAvailable)
                    {
                        book.IsAvailable = true;
                        Console.WriteLine($"Book {title} is returned.");
                        return true;
                    }
                    if (book.IsAvailable)
                    {
                        Console.WriteLine($"Book {title} is already exists.");
                        return false;
                    }
                }
            }

            Console.WriteLine($"Book {title} is not for library. ");
            return false;
        }
        public void printList()
        {
            foreach (Book book in _books)
                Console.WriteLine(book);
        }


    }
}
