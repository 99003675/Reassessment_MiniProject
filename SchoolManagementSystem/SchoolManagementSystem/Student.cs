using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    class Student : Courses
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Gender { get; set; }
        public DateTime DateOfAdmission { get; set; }
        public int RollNumber { get; set; }
        public String Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Student()
        { 

        }
    }
}
