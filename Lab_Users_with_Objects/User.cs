using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Users_with_Objects
{
    internal class User
    {
        string _firstName;
        string _lastName;
        public List<JamSession> _jamSession = new List<JamSession>();

        public User(string firstName, string lastName, List<JamSession> jamSession)
        {
            FirstName = firstName;
            LastName = lastName;
            JamSession = jamSession;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        internal List<JamSession> JamSession { get => _jamSession; set => _jamSession = value; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
