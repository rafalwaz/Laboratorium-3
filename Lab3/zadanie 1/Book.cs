using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Book
    {

        protected string Title { get; set; }

        protected Person Author { get; set; }
        protected DateTime DataWydania;

        public Book(string title, Person author, DateTime dataWydania)
        {
            Title = title;
            Author = author;
            DataWydania = dataWydania;
        }

        protected Book() 
        {
            
        }
        public virtual void View()
        {
            Console.WriteLine($"Podaj informacje o książce: {Title}, Author: {Author.FirstName} {Author.LastName},Data wydania: {DataWydania.ToShortDateString()}");
        }
    }
}
