using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SamochodOsobowy Osobowy = new SamochodOsobowy();

            Samochod samochod1 = new Samochod();
            Samochod samochod2 = new Samochod("Toyota", "Corolla", "Sedan", "Czerwony", 2020, 50000);

            Console.WriteLine("\nInformacje o samochodzie osobowym:");
            Osobowy.WyswietlInformacje();

            Console.WriteLine("\nInformacje o pierwszym samochodzie:");
            samochod1.WyswietlInformacje();

            Console.WriteLine("\nInformacje o drugim samochodzie:");
            samochod2.WyswietlInformacje();

        }
    }
}
