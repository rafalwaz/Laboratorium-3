using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Person
    {
        public string FirstName;
        public string LastName;
        public int Wiek;

        public Person(string firstName, string lastName, int wiek)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Wiek = wiek;
        }

        
        public virtual void View()
        {
            Console.WriteLine($"Podaj dane osoby: {FirstName} {LastName}, Wiek: {Wiek}");
        }

        
    }
}
