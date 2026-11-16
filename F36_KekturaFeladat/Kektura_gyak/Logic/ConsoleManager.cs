using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Kektura_gyak.Class;

namespace Kektura_gyak.Logic
{
    public class ConsoleManager
    {
        public static void SzakaszokSzama(List<Szakaszok> Kektura_Szakaszok)
        {
            Console.WriteLine("Szakaszok száma: " + Kektura_Szakaszok.Count + " db" + "\n");
        }

        public static void TeljesHossz(List<Szakaszok> Kektura_Szakaszok)
        {
            //https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.sum?view=net-10.0
            decimal OsszHossz = Kektura_Szakaszok.Sum(hsz => hsz.Hossz);
            Console.WriteLine("A túra teljes hossza: " + OsszHossz + " km" + "\n");
        }
        
        public static void Legrovidebb(List<Szakaszok> Kektura_Szakaszok)
        {
            // https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.min?view=net-10.0
            // c# at least one object must implement icomparable error
            //Szakaszok min = Kektura_Szakaszok.Min();
            //decimal Minimum = Kektura_Szakaszok.Min(rovHossz => rovHossz.Hossz);
            var Minimum = Kektura_Szakaszok.OrderBy(rovHossz => rovHossz.Hossz).First();

            Console.WriteLine("A legrövidebb szakasz adatai: " + "\n" + "Kezdete: " + Minimum.Indulopont + "\n" + "Vége: " + Minimum.Vegpont + "\n" + "Távolság: " + Minimum.Hossz + " km" + "\n");
        }

        public static void LegmagasabbPont(List<Szakaszok> Kektura_Szakaszok)
        {
            int Magassag = 192;

            Dictionary<string, int> tszintMagassag = new Dictionary<string, int>();

            foreach (var tura in Kektura_Szakaszok)
            {
                Magassag = tura.Emelkedes - tura.Lejtes;
                tszintMagassag.Add(tura.Vegpont, Magassag);

                Console.WriteLine("A túra legmagasabban fekvő pontja:" + "\n" + "A végpont neve: " + tura.Vegpont + "\n" + "A végpont tengerszint feletti magassága: " + Magassag + " m");
            }
        }
    }
}
