using HomeWork3.task1;
using HomeWork3.task2;
using HomeWork3.task3;
using HomeWork3.task4.without_designPatterns;

namespace HomeWork3
{
    public class Program
    {
        static void Main(string[] args)
        {

            //task1----------------------------------------------
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
            //book return
            while (true)
            {
                Console.WriteLine("enter book name to return: : (To end the return section enter 'exit')");
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
                    Console.WriteLine(" Return was successful.\n Current Library: ");
                    library1.printList();
                    break;
                }

            }
            //task 2------------------------------------------
            Console.WriteLine(" part task 2:----------------------------------\n");
            List<Student> students = new List<Student>();
            {
                students.Add(new Student(1, "a", 23, major: "computer"));
                students.Add(new Student(2, "b", 24, "math"));
            };
            List<Professor> professors = new List<Professor>();
            {
                professors.Add(new Professor(1, "c", 54, "mathematic"));
            };

            foreach (Student student in students)
            {
                Console.WriteLine(student.GetDetails());
            }

            foreach (Professor professor in professors)
            {
                Console.WriteLine(professor.GetDetails());
            }


            //task3-------------------------------------------
            Console.WriteLine();
            Console.WriteLine("part task3----------------------------\n");
            List<Product> products = new List<Product>();
            {
                products.Add(new Electronic("smart Phone", 1000m, 24));
                products.Add(new Clothing("pants", 200m, "L", "jean"));

            }
            foreach (Product product in products)
            {
                if (product is IDiscountable discountable)
                {
                    discountable.ApplyDiscount(25);
                }
            }
            foreach (Product product in products)
            {
                Console.WriteLine(product.GetProductDetails());
            }
            //task4-------------------------------------------
            Console.WriteLine();
            Console.WriteLine("part task4--------------------------\n");

            //definitoin of Hospital
            Hospital hospital = new Hospital();
            hospital.AddRooms(new Room(101, 2));
            hospital.AddRooms(new Room(102, 1));
            hospital.AddDoctors(new Doctor("Amini", 45, "N001", "D1", "A"));
            hospital.AddDoctors(new Doctor("Ahmadi", 39, "N002", "D2", "B"));

            //Patient Admission
            Patient p1 = new Patient("Reza", 65, "N003", "P1");
            Patient p2 = new Patient("Sara", 54, "N003", "P2");
            Patient p3 = new Patient("Baran", 34, "N004", "P3");

            hospital.AdmitPatient(p1);
            hospital.AdmitPatient(p2);
            hospital.AdmitPatient(p3);

            //check exception when a room is full
            Patient p4 = new Patient("Ali", 46, "N006", "p4");
            hospital.AdmitPatient(p4);

            //diagnose and add to patient's history
            Doctor dr = hospital.Doctors[0];
            dr.Diagnose(p1, "Flu");

            Console.WriteLine("-------------- patient details-------------");
            Console.WriteLine(p1.GetDetails());

            Console.WriteLine("\n------------Room occupancy---------------");
            hospital.ShowRooms();

            //discharge Patient
            hospital.DischargePatient(p1);




        }
    }
}
