using System.Collections.Generic;
using System.Text;

namespace CodeReader
{
    public class CodeScanner
    {
        private readonly Dictionary<string, string> _numberCodes = new Dictionary<string, string>
        {
            { " _ | ||_|", "0" },
            { "     |  |", "1" },
            { " _  _||_ ", "2" },
            { " _  _| _|", "3" },
            { "   |_|  |", "4" },
            { " _ |_  _|", "5" },
            { " _ |_ |_|", "6" },
            { " _  |   |", "7" },
        };

        private const int StartIndex = 0;
        private const int LengthLine = 3;
        private const string Separator = "\r\n";

        public string GenerateReport(string codeRaw)
        {
            try
            {
                var code = ScanCode(codeRaw);
                return "OK - " + code;
            }
            catch (InvalidCodeNumberException e)
            {
                return e.Message;
            }
        }

        public string ScanCode(string codeRaw)
        {
            if (string.IsNullOrEmpty(codeRaw.Trim()))
            {
                return "Unable to read empty string as code";
            }

            var codeBuilder = new StringBuilder();
            var codeToScan = codeRaw;
            while (codeToScan.Length > 0)
            {
                if (codeToScan.Length < 9)
                {
                    throw new InvalidCodeNumberException("Unable to read code with incomplete data.");
                }

                var extractedNumber = _numberCodes[ExtractFirstNumber(codeToScan)];
                codeToScan = ExtractRemainingNumbers(codeToScan);
                codeBuilder.Append(extractedNumber);
            }

            return codeBuilder.ToString();
        }

        public string ExtractRemainingNumbers(string codeToScan)
        {
            var lines = codeToScan.Split(Separator);
            var remainingCodes = string.Empty;
            for (var i = 0; i < 3; i++)
            {
                var line = lines[i].Substring(LengthLine, lines[i].Length - LengthLine);
                remainingCodes += !string.IsNullOrEmpty(line) && line.Length % 3 == 0 
                                    ? line + Separator 
                                    : string.Empty;
            }

            return remainingCodes;
        }

        public string ExtractFirstNumber(string codeRaw)
        {
            var lines = codeRaw.Split(Separator);
            return lines[0].Substring(StartIndex, LengthLine) +
                   lines[1].Substring(StartIndex, LengthLine) +
                   lines[2].Substring(StartIndex, LengthLine);
        }
    }
}
