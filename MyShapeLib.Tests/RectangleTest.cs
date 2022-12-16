using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary;

namespace MyShapeLib.Tests
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void GetArea_10_10_Return_100()
        {
            //arrange
            Rectangle rectangle = new Rectangle(10,10);
            double expected = 100;

            //act
            double result = rectangle.GetArea();

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetPerimeter_10_10_Return_40()
        {
            //arrange
            Rectangle rectangle = new Rectangle(10, 10);
            double expected = 40;

            //act
            double result = rectangle.GetPerimeter();

            //assert
            Assert.AreEqual(expected, result);
        }

    }
}
