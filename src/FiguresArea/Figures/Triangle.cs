using System;
using System.IO;
using FiguresArea.Exceptions;

namespace FiguresArea.Figures
{
	public class Triangle: IFigure
	{
		private readonly int _maxSide;
		private readonly int _mediumSide;
		private readonly int _minSide;

		private readonly bool _isRight;


		public Triangle(int side1, int side2, int side3)
		{
            _maxSide = Math.Max(side1, Math.Max(side2, side3));
            _minSide = Math.Min(side1, Math.Max(side2, side3));
            _mediumSide = side1 + side2 + side3 - _maxSide - _minSide;

            if (!IsValid())
				throw new InvalidTriangleException();

			_isRight = IsRight();
		}


        private bool IsValid()
        {
            if (_minSide <= 0)
                return false;

            return _mediumSide + _maxSide > _minSide && _minSide + _maxSide > _mediumSide && _minSide + _mediumSide > _maxSide;
        }


        private bool IsRight()
		{
			return _maxSide * _maxSide == _minSide * _minSide + _mediumSide * _mediumSide;
        }


        public double CalculateArea()
        {
            if (_isRight)
            {
                return (double)_minSide * _mediumSide / 2; 
            }

            double p = ((double)_minSide + _mediumSide + _maxSide) / 2;

            return Math.Sqrt(p * (p - _minSide) * (p - _mediumSide) * (p - _maxSide));
        }

        
    }
}

