using AreaFigure;
using NUnit.Framework;
using System;

namespace UnitTestFigure
{
    public class UnitTestCircle
    {

        [Test]
        public void Circle_test1()
        {
            // arrange
            Circle circle = new Circle(15);
            double correctResult = 706.858;

            //act
            double result = Math.Round(circle.Area, 3
                
                
                
                );

            //assert
            Assert.AreEqual(correctResult, result);
        }
        [Test]
        public void Circle_test2()
        {
            // arrange
            Circle circle = new Circle(10);
            double correctResult = 314.159;

            //act
            double result = Math.Round(circle.Area, 3);

            //assert
            Assert.AreEqual(correctResult, result);
        }
        [Test]
        public void Circle_test3()
        {
            // arrange
            Circle circle = new Circle(0);
            double correctResult = 0;

            //act
            double result = circle.Area;

            //assert
            Assert.AreEqual(correctResult, result);
        }

        [Test]
        public void Circle_test4()
        {
            // arrange
            Circle circle = new Circle(-10);
            double correctResult = 0;

            //act
            double result = circle.Area;

            //assert
            Assert.AreEqual(correctResult, result);
        }
    }
}