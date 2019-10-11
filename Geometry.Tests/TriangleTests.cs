using GeometryLib;
using NUnit.Framework;
using System;

namespace GeometryTests
{
    class TriangleTests
    {
        [Test]
        public void CalculateArea_CorrectArgs_CalculateRightValue()
        {
            var area1 = Geometry.CalculateArea(3, 5, 4);
            var area2 = Geometry.CalculateArea(4, 10, 8);
            Assert.AreEqual(area1, 6);
            Assert.AreEqual(area2, 15.199, 0.1);
        }

        [Test]
        public void IsTriangleRight_SidesOfRightTriangle_ReturnTrue()
        {
            Assert.IsTrue(Geometry.IsTriangleRight(4, 5, 3));
        }

        [Test]
        public void CalculateArea_IncorectArgs_ThrowsExc()
        {
            Assert.Throws<ArgumentException>(() => Geometry.CalculateArea(10, 100, 8));
            Assert.Throws<ArgumentException>(() => Geometry.CalculateArea(0, 100, 8));
            Assert.Throws<ArgumentException>(() => Geometry.CalculateArea(10, -1, 8));
        }

        [Test]
        public void IsTriangleRight_IncorectArgs_ThrowsExc()
        {
            Assert.Throws<ArgumentException>(() => Geometry.IsTriangleRight(10, 100, 8));
        }
    }
}
