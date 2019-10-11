using System;
using NUnit.Framework;
using GeometryLib;

namespace GeometryTests
{
    public class CircleTests
    {
        [Test]
        public void CalculateArea_OneArg_CalculateRightValue()
        {
            var area = Geometry.CalculateArea(10, 3.14);
            Assert.AreEqual(area, 314,0.1);
        }

        [Test]
        public void CalculateArea_OneArgEqZero_ThrowsExc()
        {
            Assert.Throws<ArgumentException>(() => Geometry.CalculateArea(0));
        }
    }
}