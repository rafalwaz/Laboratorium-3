using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    internal class SamochodOsobowy : Samochod
    {
        public double Waga { get; set; }
        public double PojemnośćSilnika { get; set; }
        public int IlośćOsób { get; set; }

        public SamochodOsobowy()
        {
            Console.WriteLine("Podaj dodatkowe informacje o samochodzie:");
            do
            {
                Console.Write("Waga (2t - 4.5t):");
                Waga = double.Parse(Console.ReadLine());
            } while (Waga < 2 || Waga > 4.5);

            do
            {
                Console.Write("Pojemność silnika (0,8 - 3,0):");
                PojemnośćSilnika = double.Parse(Console.ReadLine());
            } while (PojemnośćSilnika < 0.8 || PojemnośćSilnika > 3.0);

            Console.Write("Ilość osób:");
            IlośćOsób = int.Parse(Console.ReadLine());
        }

        public new void WyswietlInformacje()
        {
            base.WyswietlInformacje();
            Console.WriteLine($"Waga: {Waga} t");
            Console.WriteLine($"Pojemność silnika: {PojemnośćSilnika} l");
            Console.WriteLine($"Ilość osób: {IlośćOsób}");
        }
    }
}
