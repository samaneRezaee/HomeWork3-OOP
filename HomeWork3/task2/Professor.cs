

namespace HomeWork3.task2
{
    public class Professor : Person
    {
        public int ProfessorId { get; set; }
        public string Subject { get; set; }

        public Professor() { }
        public Professor(int professorId, string name, int age, string subject) : base(name, age)
        {
            ProfessorId = professorId;
            Subject = subject;
        }

        public override string GetDetails()
        {
            return $"Professor ID: {ProfessorId}, " + base.GetDetails() + $", Subject: {Subject}";
        }
    }
}
