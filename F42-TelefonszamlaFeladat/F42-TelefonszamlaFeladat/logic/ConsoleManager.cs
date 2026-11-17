using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace F42_TelefonszamlaFeladat.logic
{
    public class ConsoleManager
    {
        public static void TelszamValid()
        {
            Console.WriteLine("Adja meg a telefonszámot: ");
            string Telefonszam = Console.ReadLine();

            if (Telefonszam.StartsWith("39"))
            {
                Console.WriteLine("A megadott telefonszám mobil hívószám.");
            }
            else if (Telefonszam.StartsWith("41"))
            {
                Console.WriteLine("A megadott telefonszám mobil hívószám.");
            }
            else if (Telefonszam.StartsWith("71"))
            {
                Console.WriteLine("A megadott telefonszám mobil hívószám.");
            }
            else
            {
                Console.WriteLine("A megadott telefonszám vezetékes hívószám.");
            }
        }

        public static void TelefonIdotartam()
        {
            Console.WriteLine("Adja meg a hívás kezdetét (H m s): ");
            string telefonKezdett = Console.ReadLine();

            Console.WriteLine("Adja meg a hívás befejezését (H m s): ");
            string telefonVeg = Console.ReadLine();

            DateTime kezdes = DateTime.ParseExact(telefonKezdett, "H m s", CultureInfo.InvariantCulture);
            DateTime veg = DateTime.ParseExact(telefonVeg, "H m s", CultureInfo.InvariantCulture);

            var szamitas = veg.Subtract(kezdes);
            Console.WriteLine("A hívás hossza: " + szamitas);
        }
    }
}
