using System;
namespace FiguresArea.Figures
{
	public class FiguresFactory
	{
        public IFigure CreateFigure(int radius)
        {
            return new Circle(radius);
        }


        public IFigure CreateFigure(int side1, int side2, int side3)
        {
            return new Triangle(side1, side2, side3);
        }

    }
}

