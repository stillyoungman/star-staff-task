using System;
using System.Linq;

namespace GeometryLib
{
    public static class Geometry
    {
        const double _pi = 3.14;

        /// <summary>
        /// Calculate area of circle
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static double CalculateArea(double radius, double pi = _pi )
        {
            if (radius == 0)
            {
                throw new ArgumentException("Invalid input data");
            }

            return pi * Math.Pow(radius, 2);
        }

        public static double CalculateArea(double a, double b, double c)
        {
            if (!IsExistedTriangle(a, b, c)) throw new ArgumentException("Invalid input data");

            var s = (a + b + c) / 2; //semiperimeter
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public static bool IsTriangleRight(double a, double b, double c)
        {

            if (!IsExistedTriangle(a, b, c)) throw new ArgumentException("Invalid input data");

            //find hepotenuse
            var sides = new double[3] { a, b, c };

            Array.Sort(sides);
            var h = sides[2]; //hepotenuse
            var s1 = sides[1];
            var s2 = sides[0];

            //check
            return Math.Pow(h, 2) == Math.Pow(s1, 2) + Math.Pow(s2, 2);
        }

        /// <summary>
        /// Check is that possible to construct the triangle with provided sides
        /// </summary>
        /// <returns></returns>
        private static bool IsExistedTriangle(double a, double b, double c) => 
            !(new double[3] { a, b, c }.Any(n => n <= 0)
                || a >= b + c
                || b >= a + c
                || c >= b + a);
    }
}


