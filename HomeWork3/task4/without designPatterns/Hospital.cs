

namespace HomeWork3.task4.without_designPatterns
{
    public class Hospital
    {
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
        public List<Room> Rooms { get; set; } = new List<Room>();

        public Hospital() { }

        public void AddDoctors(Doctor doctor)
        {
            Doctors.Add(doctor);
        }
        public void AddRooms(Room room)
        {
            Rooms.Add(room);
        }
        public void AdmitPatient(Patient patient)
        {
            foreach (Room room in Rooms)
            {
                if (room.HasAvailableSpace)
                {
                    room.AssignPatient(patient);
                    Console.WriteLine($"{patient.Name} admitted to room {room.RoomNumber}");
                    return;
                }
            }
            Console.WriteLine("There is no room availble");
        }
        public void DischargePatient(Patient patient)
        {
            foreach (Room room in Rooms)
            {
                if (room.Patients.Contains(patient))
                {
                    room.RemovePatient(patient);
                    Console.WriteLine($"{patient.Name} discharged from room {room.RoomNumber}.");
                    return;
                }
            }
            Console.WriteLine($"{patient.Name} not found in any room.");
        }
        public void ShowDoctors() 
        {
            foreach (Doctor doctor in Doctors)
            {
                Console.WriteLine(doctor.GetDetails());
            }
        }
        public void ShowRooms()
        {
            foreach (Room room in Rooms)
            {
                Console.WriteLine(room);
            }
        }
    }
}
