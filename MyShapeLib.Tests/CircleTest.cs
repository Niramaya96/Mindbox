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
    }
}