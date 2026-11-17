using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F42_TelefonszamlaFeladat.logic
{
    public class FileReadWrite
    {
        public static void ReadFile(string filepath)
        {
            var read = File.ReadAllLines(filepath);

            for (int i = 0; i < read.Length; i += 2)
            {
                var firstLine = read[i];
                var kezdet = firstLine
                var secondLine = read[i + 1];

                string telszamLine = secondLine.ToString();

                var Line = $"{firstLine}, {telszamLine}";
                Console.WriteLine(Line);
            }
        }
    }
}
