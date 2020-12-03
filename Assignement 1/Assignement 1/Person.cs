using System;
using System.Collections.Generic;
using System.Text;

namespace Assignement_1
{
    class Person
    {
        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FirstName
        {
            get { return firstName; }
        }
        public string LastName
        {
            get { return lastName; }
        }
    }
}
