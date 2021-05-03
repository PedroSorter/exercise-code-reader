using System.IO;
using CodeReader;
using FluentAssertions;
using Xunit;

namespace CodeReaderTest
{
    public class CodeScannerTest
    {
        [Theory]
        [InlineData("00")]
        [InlineData("000000000")]
        [InlineData("111111111")]
        [InlineData("222222222")]
        [InlineData("333333333")]
        [InlineData("444444444")]
        [InlineData("555555555")]
        [InlineData("666666666")]
        [InlineData("777777777")]
        [InlineData("1234567")]
        public void ShouldReadAllCodesFromFolder(string expected)
        {
            var scanner = new CodeScanner();
            var input = File.ReadAllText($"./codes/{expected}.txt");
            var actual = scanner.ScanCode(input);
           
           actual.Should().BeEquivalentTo(expected);
        }
    }
}
