using System;

namespace Mh.Aladin
{
    public class AladinException : Exception
    {
        public int ErrorCode { get; }

        public AladinException()
        { }

        public AladinException(string message)
            : base(message)
        { }

        public AladinException(int errorCode, string message)
            : base(message)
        {
            ErrorCode = errorCode;
        }
    }
}
