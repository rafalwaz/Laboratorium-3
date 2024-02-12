using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Reviewer : Reader
    {

        public Reviewer(string firstName, string lastName, int wiek) : base(firstName, lastName, wiek)
        {

        }

        public void RecenzjeKsiążki()
        {
            Console.WriteLine($"Recenzja przez {FirstName} {LastName}:");
            foreach (var book in przeczytaneKsiążki)
            {
                book.View();
                Console.WriteLine($"Ocena: {LosowaOcena()}");
            }
        }

        
        private int LosowaOcena()
        {
            Random random = new Random();
            return random.Next(1, 5);
        }

    }
}
