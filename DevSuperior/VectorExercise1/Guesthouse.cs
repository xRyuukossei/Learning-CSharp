using System;

namespace VectorExercise1
{
    internal class Guesthouse
    {
        private string _name;
        private string _email;
        private int _roomNumber;

        public Guesthouse(string name, string email, int roomNumber)
        {
            _name = name;
            _email = email;
            _roomNumber = roomNumber;
        }

        public override string ToString()
        {
            return _roomNumber + ": " + _name + ", " + _email;
        }
    }
}
