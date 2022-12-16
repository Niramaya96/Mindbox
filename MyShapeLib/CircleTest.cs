using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary;

namespace MyShapeLib.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void GetArea_10_Return_314_16()
        {
            //arrange
            Circle circle = new Circle(10);
            double expected = 314.16;

            //act
            double result = circle.GetArea();

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetPerimeter_10_Return_62_83()
        {
            //arrange
            Circle circle = new Circle(10);
            double expected = 62.83;

            //act
            double result = circle.GetPerimeter();

            //assert
            Assert.AreEqual(expected, result);
        }
    }
}