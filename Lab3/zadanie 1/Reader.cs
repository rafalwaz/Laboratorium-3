using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Reader : Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public List<Book> przeczytaneKsiążki { get; set; }
        public Reader(string firstName, string lastName, int wiek) : base(firstName, lastName, wiek)
        {
            przeczytaneKsiążki = new List<Book>();
        }

        public void AddBook(Book book)
        {
            przeczytaneKsiążki.Add(book);
        }

        public void ViewBook()
        {
            Console.WriteLine($"Książki przeczytane przez{firstName} {lastName}:");
            foreach (var book in przeczytaneKsiążki)
            {
                book.View();
            }
        }

        public override void View()
        {
            base.View();
            ViewBook();
        }

    }
}
