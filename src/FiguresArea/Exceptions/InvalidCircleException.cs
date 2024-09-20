using System;
namespace FiguresArea.Exceptions
{
	public class InvalidCircleException: Exception
	{
        public InvalidCircleException() { }

        public InvalidCircleException(string message)
            : base(message) { }

        public InvalidCircleException(string message, Exception inner)
            : base(message, inner) { }
    }
}

