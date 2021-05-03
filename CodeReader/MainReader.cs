using System;
using System.IO;
using System.Text;

namespace CodeReader
{
    public class MainReader
    {

        public bool ReadCodesFromFiles()
        {
            var builder = new StringBuilder();
            var scanner = new CodeScanner();
            foreach (var file in Directory.EnumerateFiles("./codes", "*.txt"))
            {
                builder.Append(scanner.GenerateReport(File.ReadAllText(file)));
            }

            return builder.Length > 0;
        }

    }
}
