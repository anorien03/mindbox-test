using System;
using FiguresArea.Exceptions;
using FiguresArea.Figures;

namespace FiguresArea.UnitTests
{
    public class CircleUnitTests
    {
        private const double Epsilon = 1e-10;

        [Fact]
        public void CalculateAreaOkTest()
        {
            int radius = 4;
            var expectedArea = Math.PI * 16;

            var actualArea = new FiguresFactory().CreateFigure(radius).CalculateArea();

            Assert.True(Math.Abs(actualArea - expectedArea) < Epsilon);
        }


        [Fact]
        public void CalculateAreaInvalidRadiusTest()
        {
            int radius = -1;

            Assert.Throws<InvalidCircleException>(() => new FiguresFactory().CreateFigure(radius).CalculateArea());
        }
    }
}

