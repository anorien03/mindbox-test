using System;
using FiguresArea.Exceptions;

namespace FiguresArea.Figures
{
	public class Circle: IFigure
	{
        private readonly int _radius;

		public Circle(int radius)
		{
            if (radius <= 0)
                throw new InvalidCircleException();

            _radius = radius;
		}


        public double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}

