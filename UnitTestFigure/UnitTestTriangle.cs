using AreaFigure;
using NUnit.Framework;
using System;
using static AreaFigure.Triangle;

namespace UnitTestFigure
{
    public class UnitTestTriangle
    {
        [Test]
        public void Triangle_test1()
        {
            // arrange
            Triangle circle = new Triangle(1,1,1);
            double correctResult = 0.43;

            //act
            double result = Math.Round(circle.Area, 2);

            //assert
            Assert.AreEqual(correctResult, result);
        }
        [Test]
        public void Triangle_test2()
        {
            // arrange
            Triangle circle = new Triangle(5, 2, 6);
            double correctResult = 4.68;

            //act
            double result = Math.Round(circle.Area, 2);

            //assert
            Assert.AreEqual(correctResult, result);
        }
        [Test]
        public void Triangle_test3()
        {
            // arrange
            Triangle circle = new Triangle(1, 3, 3);
            double correctResult = 1.48;

            //act
            double result = Math.Round(circle.Area, 2);

            //assert
            Assert.AreEqual(correctResult, result);
        }
        [Test]
        public void Triangle_test4()
        {
            // arrange
            Triangle circle = new Triangle(5, 4, 3);
            TypeTriangle correctResult = TypeTriangle.rightTriangle;

            //act
            TypeTriangle result = circle.getTypeTriangle();

            //assert
            Assert.AreEqual(correctResult, result);
        }

        [Test]
        public void Triangle_test5()
        {
            // arrange
            Triangle circle = new Triangle(-4, 16, 0);
            TypeTriangle correctResult = TypeTriangle.notTriangle;

            //act
            TypeTriangle result = circle.getTypeTriangle();

            //assert
            Assert.AreEqual(correctResult, result);
        }

        [Test]
        public void Triangle_test6()
        {
            // arrange
            Triangle circle = new Triangle(5.1, 4.1, 3.1);
            TypeTriangle correctResult = TypeTriangle.versatileTriangle;

            //act
            TypeTriangle result = circle.getTypeTriangle();

            //assert
            Assert.AreEqual(correctResult, result);
        }
    }
}
