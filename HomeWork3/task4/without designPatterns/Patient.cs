

namespace HomeWork3.task4.without_designPatterns
{
    public class Patient: Person
    {
        public string PatientId { get; set; }
        public List<string> MedicalHistory { get; set; } = new List<string>();

        public Patient() { }
        public Patient(string name, int age, string nationalId, string patientId): base(name, age, nationalId) 
        { 
            PatientId = patientId;
            
        }
        public void AddToMedicalHistory(string disease) 
        {
            MedicalHistory.Add(disease);
        }
    }
}
