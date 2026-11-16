using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kektura_gyak.Class;

namespace Kektura_gyak.Logic
{
    public class CsvReader
    {
        public static void ReadCsv(string Filename, List<Szakaszok> Kektura_Szakaszok)
        {
            using (var sr = new StreamReader(Filename))
            {
                string header = sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] rowData = line.Split(';');
                    var Szakasz = new Szakaszok();

                    Szakasz.Indulopont = rowData[0];
                    Szakasz.Vegpont = rowData[1];
                    Szakasz.Hossz = decimal.Parse(rowData[2]);
                    Szakasz.Emelkedes = int.Parse(rowData[3]);
                    Szakasz.Lejtes = int.Parse(rowData[4]);
                    Szakasz.PecseteloHely = rowData[5];

                    Kektura_Szakaszok.Add(Szakasz);
                }
            }
        }
    }
}
