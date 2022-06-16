using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class Person
    {
        //fields
        private string _name;
        private int _age;
        public string Email { get; set; }

        //properties
        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value ; }
        }

        public Person(string name, string email, int age)
        {
            _age = age;
            _name = name;
            Email = email;
        }
        public Person()
        {

        }

        private bool IsEligibleToWork()
        {
            if(_age > 17)
            {
               return true;
            }
            else
            {
               return false;
            }
        }

        public void IsEligibleForVisa()
        {
            if(IsEligibleToWork())
            {
                Console.WriteLine("Grant Visa");
            }
            else
            {
                Console.WriteLine("Deny Visas");
            }
        }
    }
}
