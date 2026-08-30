

namespace HomeWork3.task1
{
    public class Book
    {
        private string _title;
        private string _author;
        private string _isbn;
        private bool _isAvailable = true;

        public Book() { }
        public Book(string title, string author, string isbn)
        {
            _title = title;
            _author = author;
            _isbn = isbn;
        }
        public string Title { get { return _title; } set { _title = value; } }
        public string Author { get { return _author; } set { _author = value; } }
        public bool IsAvailable { get { return _isAvailable; } set { _isAvailable = value; } }
        public string Isbn { get { return _isbn; } set { _isbn = value; } }



        public override string ToString()
        {
            return "book: "+_title + " " + _author + " " + _isbn + " " + _isAvailable + "\n";
        }
    }
}
