

namespace HomeWork3.task4.without_designPatterns
{
    public class Doctor: Person
    {
        public string DoctorId { get; set; }
        public string Specialization {  get; set; }
        public Doctor() { }
        public Doctor(string name, int age, string nationalId, string doctorId, string specialization)
            : base(name, age, nationalId)
        {
            DoctorId = doctorId;
            Specialization = specialization;
        }
        public void Diagnose(Patient patient, string disease)
        {
            patient.AddToMedicalHistory(disease);
            Console.WriteLine($"Dr.{Name} diagnosed {patient.Name} with: {disease}");
        }
    }
}
