using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class Student : Person
    {
        public string StudentID { get; set; }
        public Student():base()
        {

        }

        public Student(string name, string email, int age, string studentID):base(name,email,age)
        {
            StudentID = studentID;
        }
    }
}
