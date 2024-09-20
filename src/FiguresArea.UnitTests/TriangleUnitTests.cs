using System;
using FiguresArea.Exceptions;
using FiguresArea.Figures;

namespace FiguresArea.UnitTests
{
	public class TriangleUnitTests
	{
        private const double Epsilon = 1e-10;

        [Fact]
        public void CalculateAreaOkTest()
        {
            int side1 = 7; int side2 = 10; int side3 = 11;
            var expectedArea = Math.Sqrt(14.0 * 7.0 * 4.0 * 3.0);

            var actualArea = new FiguresFactory().CreateFigure(side1, side2, side3).CalculateArea();

            Assert.True(Math.Abs(actualArea - expectedArea) < Epsilon);
        }


        [Fact]
        public void CalculateAreaRightTriangleOkTest()
        {
            int side1 = 3; int side2 = 4; int side3 = 5;
            double expectedArea = 6.0;

            var actualArea = new FiguresFactory().CreateFigure(side1, side2, side3).CalculateArea();

            Assert.True(Math.Abs(actualArea - expectedArea) < Epsilon);
        }


        [Fact]
        public void CalculateAreaInvalidSideTest()
        {
            int side1 = 11; int side2 = 10; int side3 = 0;

            Assert.Throws<InvalidTriangleException>(() => new FiguresFactory().CreateFigure(side1, side2, side3).CalculateArea());
        }


        [Fact]
        public void CalculateAreaUnexistingTriangleTest()
        {
            int side1 = 11; int side2 = 10; int side3 = 21;

            Assert.Throws<InvalidTriangleException>(() => new FiguresFactory().CreateFigure(side1, side2, side3).CalculateArea());
        }
    }
}

