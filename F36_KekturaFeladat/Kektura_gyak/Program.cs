using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Kektura_gyak.Class;
using Kektura_gyak.Logic;

namespace Kektura
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Kektura_Szakaszok = new List<Szakaszok>();
            CsvReader.ReadCsv("./csv/kektura.csv", Kektura_Szakaszok);

            //Szakasz_szam = ConsoleManager.SzakaszokSzama(Kektura_Szakaszok);
            Console.WriteLine("3. feladat: ");
            ConsoleManager.SzakaszokSzama(Kektura_Szakaszok);

            Console.WriteLine("4. feladat: ");
            ConsoleManager.TeljesHossz(Kektura_Szakaszok);

            Console.WriteLine("5. feladat: ");
            ConsoleManager.Legrovidebb(Kektura_Szakaszok);

            Console.WriteLine("8. feladat: ");
            ConsoleManager.LegmagasabbPont(Kektura_Szakaszok);
        }
    }
}
