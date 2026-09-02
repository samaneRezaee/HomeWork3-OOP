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

            Console.WriteLine("Current Library:");
            library1.printList();

            //book borrowing
            while (true)
            {
                Console.WriteLine("enter book name to borrow: (To end the borrow section enter 'exit')");
                string title = Console.ReadLine();
                if (title != null) 
                { 
                    title = title.Trim();
                }
                if (string.IsNullOrEmpty(title)) 
                {
                    Console.WriteLine("Title can not be null, please try again!");
                    continue;
                }
                if (title == "exit")
                {
                    break;
                }
                if (library1.BorrowBook(title))
                {
                    Console.WriteLine(" Borrow was successful.\n Current Library: ");
                    library1.printList();
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("enter book name to return: : (To end the borrow section enter 'exit')");
                string returnTitle = Console.ReadLine();
                if (returnTitle != null)
                {
                    returnTitle = returnTitle.Trim();
                }
                if (string.IsNullOrEmpty(returnTitle))
                {
                    Console.WriteLine("Title can not be null, please try again!");
                    continue;
                }
                if (returnTitle == "exit")
                {
                    break;
                }
                if (library1.ReturnBook(returnTitle))
                {
                    Console.WriteLine(" Return was successful.\\n Current Library: \");");
                    library1.printList();
                    break;
                }

            }
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
