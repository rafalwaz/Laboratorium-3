using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class AdventureBook : Book
    {
        protected string Setting;

        public AdventureBook(string title,Person author, DateTime  releaseDate, string setting) : base(title, author, releaseDate)
        {
            Setting = setting;
        }

        public override void View()
        {
            base.View();
            Console.WriteLine($"Setting: {Setting}");
        }
    }
}
