using System;
namespace FiguresArea.Exceptions
{
	public class InvalidTriangleException: Exception
	{
        public InvalidTriangleException() { }

        public InvalidTriangleException(string message)
            : base(message) { }

        public InvalidTriangleException(string message, Exception inner)
            : base(message, inner) { }
    }
}

