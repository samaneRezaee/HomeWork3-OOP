

namespace HomeWork3.task4.without_designPatterns
{
    public class RoomFullException : Exception
    {
        public RoomFullException() { }
        public RoomFullException(string message) : base(message) { }
    }
}
