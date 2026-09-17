

namespace HomeWork3.task4.without_designPatterns
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }
        public List<Patient> Patients { get; set; } = new List<Patient>();
        public Room() { }
        public Room(int roomNumber, int capacity) 
        {
            RoomNumber = roomNumber;
            Capacity = capacity;
        }
        public bool HasAvailableSpace => Patients.Count < Capacity;
        public void AssignPatient(Patient patient) 
        {
            if (Patients.Count >= Capacity) 
            {
                throw new RoomFullException($"Room {RoomNumber} is full");
            }
            Patients.Add(patient);
        }

        public void RemovePatient(Patient patient) 
        {
            Patients.Remove(patient);
        }
        public override string ToString()
        {
            return $"Room {RoomNumber} ({Patients.Count}/{Capacity} is occupied.";
        }
    }
}
