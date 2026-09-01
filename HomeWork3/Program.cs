using HomeWork3.task1;
using HomeWork3.task2;

namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //task1
            Book book1 = new Book("a", "b", "123");
            Book book2 = new Book("c", "d", "456");
            Book book3 = new Book("e", "f", "789");
            Book book4 = new Book("g", "h", "435");

            Library library1 = new Library();
            library1.AddBook(book1);
            library1.AddBook(book2);
            library1.AddBook(book3);
            library1.AddBook(book4);

            library1.printList();

            Console.WriteLine("enter book name to borrow: ");
            string title = Console.ReadLine();
            library1.BorrowBook(title);
            library1.printList();

            Console.WriteLine("enter book name to return: ");
            string returnTitle = Console.ReadLine();
            library1.ReturnBook(returnTitle);
            library1.printList();

            //task 2
            Console.WriteLine(" part task 2:");

            List<Person> p = new List<Person>();
            {
                p.Add(new Student(1, "a", 23, "computer"));
                p.Add(new Student(2, "b", 24, "math"));
                p.Add(new Professor(1, "c", 54, "mathematic"));
            };

            foreach (Person person in p)
            {

                Console.WriteLine(person.GetDetails());
            }


        }
    }
}
