using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain
{
    public class Teacher : IUser
    {
        public Teacher()
        {

        }

        public Teacher(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        public int Id { get; set; }
        public string FirstName { get; set ; }
        public string LastName { get; set ; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
