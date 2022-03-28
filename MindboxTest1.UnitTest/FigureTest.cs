using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxTest1.Library;
using System;

namespace MindboxTest1.UnitTest
{
    [TestClass]
    public class FigureTest
    {

        [TestMethod]
        public void TestCircle()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Figure<CircleParameter, CircleCalculator>(new CircleParameter(-5))); // Неверные переданные параметры

            Figure<CircleParameter, CircleCalculator> circle = new Figure<CircleParameter, CircleCalculator>(new CircleParameter(10));
            var result = circle.GetResults();

            Assert.IsNotNull(result);
            Assert.AreNotEqual(0, result.Perimeter); 
            Assert.AreNotEqual(0, result.Area);
        }

        [TestMethod]
        public void TestTriangle()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Figure<TriangleParameter, TriangleCalculator>(new TriangleParameter(-5, 5, 1))); // Неверные переданные параметры

            Figure<TriangleParameter, TriangleCalculator> triangle = new Figure<TriangleParameter, TriangleCalculator>(new TriangleParameter(6, 8, 10));
            var result = triangle.GetResults();

            Assert.IsNotNull(result);
            Assert.AreNotEqual(0, result.Perimeter);
            Assert.AreNotEqual(0, result.Area);
            Assert.IsTrue(result.IsRightTriangle);

            triangle = new Figure<TriangleParameter, TriangleCalculator>(new TriangleParameter(6, 8, 12));
            var result2 = triangle.GetResults();

            Assert.IsNotNull(result2);
            Assert.AreNotEqual(0, result.Perimeter);
            Assert.AreNotEqual(0, result.Area);
            Assert.IsFalse(result2.IsRightTriangle);


        }


        [TestMethod]
        public void TestEllipse()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Ellipse(-2,3)); // Неверные переданные параметры

            Ellipse ellipse = new Ellipse(2,3);
            var result = ellipse.GetResults();

            Assert.IsNotNull(result);
            Assert.AreNotEqual(0, result.Perimeter);
            Assert.AreNotEqual(0, result.Area);
        }

    }
}
