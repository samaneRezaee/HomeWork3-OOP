

namespace HomeWork3.task2
{
    public class Student : Person
    {
        public int StudentId { get; set; }
        public string Major {  get; set; }
        
        public Student() { }
        public Student(int id,string name, int age, string major): base (name, age)
        {
            StudentId = id;
            Major = major;
        }
        public override string GetDetails()
        {
            return $"Student ID: {StudentId}, "+base.GetDetails()+ $" ,Magor: {Major}";
        }
    }
}
