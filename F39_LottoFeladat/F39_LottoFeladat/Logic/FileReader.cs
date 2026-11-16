using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F39_LottoFeladat.Logic
{
    internal class FileReader
    {
        public const string fileName = "lottosz.dat";

        public static void fileReader()
        {
            using (var fs = new StreamReader(fileName))
            {

            }
        }
    }
}
