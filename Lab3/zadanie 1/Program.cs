using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadanie 1a
            Person author1 = new Person("Jan", "Nowak", 27);
            Person author2 = new Person("Tomek", "Kowalski", 32);

            Book book1 = new Book("Programowanie obiektowe", author1, new DateTime(2023, 6, 1));
            Book book2 = new Book("Bazy danych", author2, new DateTime(2023, 8, 9));

            book1.View();
            book2.View();

            //zadanie 1b
            Reader reader1 = new Reader("Robert", "Świątek", 25);
            Reader reader2 = new Reader("Emil", "Ostrowski", 29);

            reader1.przeczytaneKsiążki.Add(book1);
            reader1.przeczytaneKsiążki.Add(book2);
            reader2.przeczytaneKsiążki.Add(book2);

            reader1.ViewBook();
            reader2.ViewBook();

            //zadanie 1c
            reader1.View();
            Console.WriteLine();
            reader2.View();

            //zadanie 1d
            Person o = new Reader("Jan", "Nowak", 27);
            o.View();

            //zadanie 1f
            Reviewer reviewer1 = new Reviewer("Anna", "Kowalska", 34);
            Reviewer reviewer2 = new Reviewer("Marek", "Bieś", 41);

            reviewer1.przeczytaneKsiążki.Add(book1);
            reviewer1.przeczytaneKsiążki.Add(book2);
            reviewer2.przeczytaneKsiążki.Add(book2);

            reviewer1.RecenzjeKsiążki();
            reviewer2.RecenzjeKsiążki();

            //zadnie 1g
            List<Person> people = new List<Person>();

            people.Add(reader1);
            people.Add(reader2);
            people.Add(reviewer1);
            people.Add(reviewer2);

            foreach(var person in people)
            {
                person.View();
                Console.WriteLine();
            }
            //zadanie 1h

            List<Person> people1 = new List<Person>();

            people.Add(new Reader("Robert", "Świątek", 25));
            people.Add(new Reader("Emil", "Ostrowski", 29));
            people.Add(new Reviewer("Anna", "Kowalska", 34));
            people.Add(new Reviewer("Marek", "Bieś", 41));

            foreach (var person in people)
            {
                person.View();
                Console.WriteLine();
            }

            //zadanie 1i

            AdventureBook adventureBook = new AdventureBook("Nowy Świat", new Person("Michał", "Głód", 32), new DateTime(2000, 3, 15), "Mój Ogród");
            DocumentaryBook documentaryBook = new DocumentaryBook("Mały Książe", new Person("Dawid", "Czarek", 40), new DateTime(2010, 7, 22), "Chłopiec");

            adventureBook.View();
            Console.WriteLine();
            documentaryBook.View();
        }
    }
}
