using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F39_LottoFeladat
{
    internal class Program
    {
        public static void szamRendez()
        {
            Console.WriteLine("Adja meg az 52. heti sorsolás nyerőszámait: ");
            int szamok = Convert.ToInt32(Console.ReadLine());

            int[] szamTomb = new int[szamok];

            Array.Sort(szamTomb);

            Console.WriteLine("A nyerőszámok sorrendben: " + szamTomb);
        }

        static void Main(string[] args)
        {
            szamRendez();
        }
    }
}
