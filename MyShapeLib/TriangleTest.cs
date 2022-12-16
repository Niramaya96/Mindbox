using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary;

namespace MyShapeLib.Tests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void GetArea_10_10_10_Return_43_30()
        {
            //arrange
            Triangle triangle = new Triangle(10, 10, 10);
            double expected = 43.30;

            //act
            double result = triangle.GetArea();

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetPerimeter_10_10_10_Return_30()
        {
            //arrange
            Triangle triangle = new Triangle(10, 10, 10);
            double expected = 30;

            //act
            double result = triangle.GetPerimeter();

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckRightTriangle_10_10_10_Return_False()
        {
            //arrange
            Triangle triangle = new Triangle(10, 10, 10);
            bool expected = false;

            //act
            bool isRight = triangle.CheckRightTriangle();

            //assert
            Assert.AreEqual(expected, isRight);
        }

        [TestMethod]
        public void CheckRightTriangle_6_10_8_Return_True()
        {
            //arrange
            Triangle triangle = new Triangle(6, 10, 8);
            bool expected = true;

            //act
            bool isRight = triangle.CheckRightTriangle();

            //assert
            Assert.AreEqual(expected, isRight);
        }


    }
}
