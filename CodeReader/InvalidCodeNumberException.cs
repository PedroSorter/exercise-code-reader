using System;

namespace CodeReader
{
    public class InvalidCodeNumberException : Exception
    {
        public InvalidCodeNumberException(string message) : base(message)
        {
        }
    }
}
