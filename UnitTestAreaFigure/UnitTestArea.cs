using System;
using AreaFigure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAreaFigure
{
    [TestClass]
    public class UnitTestArea
    {
        [TestMethod]
        public void TestMethodAreaCircle()
        {
            AreaCircleProvider areaCircle = new AreaCircleProvider();

            Assert.AreEqual(areaCircle.GetArea(new double[] { }), null);
            Assert.AreEqual(areaCircle.GetArea(new double[] { -2 }), null);
            Assert.AreEqual(areaCircle.GetArea(new double[] { 0 }), null);
            Assert.AreEqual(areaCircle.GetArea(new double[] { 1, 2 }), null);

            Assert.AreEqual(Math.Round(areaCircle.GetArea(new double[] { 2 }).Value, 2), 12.57);
        }

        [TestMethod]
        public void TestMethodAreaTriangle()
        {
            AreaTriangleProvider areaTriangle = new AreaTriangleProvider();

            Assert.AreEqual(areaTriangle.GetArea(new double[] { }), null);
            Assert.AreEqual(areaTriangle.GetArea(new double[] { 1, 2 }), null);
            Assert.AreEqual(areaTriangle.GetArea(new double[] { 0, 1, 2 }), null);
            Assert.AreEqual(areaTriangle.GetArea(new double[] { 1, 2, -2 }), null);
            Assert.AreEqual(areaTriangle.GetArea(new double[] { 1, 20, 2 }), null);
            Assert.AreEqual(areaTriangle.GetArea(new double[] { 1, 2, 3, 4}), null);

            Assert.AreEqual(areaTriangle.IsRightTriangle(new double[] { }), null);
            Assert.AreEqual(areaTriangle.IsRightTriangle(new double[] { 1, 2 }), null);
            Assert.AreEqual(areaTriangle.IsRightTriangle(new double[] { 0, 1, 2 }), null);
            Assert.AreEqual(areaTriangle.IsRightTriangle(new double[] { 1, 2, -2 }), null);
            Assert.AreEqual(areaTriangle.IsRightTriangle(new double[] { 1, 20, 2 }), null);
            Assert.AreEqual(areaTriangle.IsRightTriangle(new double[] { 1, 2, 3, 4 }), null);

            Assert.AreEqual(areaTriangle.GetArea(new double[] { 3, 4, 5 }), 6);
            Assert.AreEqual(areaTriangle.IsRightTriangle(new double[] { 3, 4, 5 }), true);
            Assert.AreEqual(areaTriangle.IsRightTriangle(new double[] { 5, 5, 5 }), false);
        }
    }
}