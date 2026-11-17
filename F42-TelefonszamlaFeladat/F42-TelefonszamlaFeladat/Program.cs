using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F42_TelefonszamlaFeladat.logic;

namespace F42_TelefonszamlaFeladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "data/HIVASOK.TXT";

            Console.WriteLine("1. feladat");
            ConsoleManager.TelszamValid();

            Console.WriteLine("\n" + "2. feladat");
            ConsoleManager.TelefonIdotartam();

            //3. feladat
            FileReadWrite.ReadFile(filepath);
        }
    }
}
