using SquareLibr.Interface;
using System;

namespace SquareLibr
{
    public class Triangle : Shape, ITriangleRight
    {
        #region [Field]

        private double a;
        private double b;
        private double c;

        #endregion

        #region [Properties]

        public double A
        {
            get => a;
            set
            {
                if (value <= 0)
                    throw new ArgumentException($"Argument equal or less then zero.");

                a = value;
            }
        }

        public double B
        {
            get => b;
            set
            {
                if (value <= 0)
                    throw new ArgumentException($"Argument equal or less then zero.");

                b = value;
            }
        }

        public double C
        {
            get => c;
            set
            {
                if (value <= 0)
                    throw new ArgumentException($"Argument equal or less then zero.");

                c = value;
            }
        }

        public override double Area
        {
            get
            {
                var p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }

        public bool IsRight
        {
            get
            {
                if (A > B && A > C)
                {
                    return A == Math.Sqrt(B * B + C * C);
                }
                else if (B > A && B > C)
                {
                    return B == Math.Sqrt(A * A + C * C);
                }
                else if (C > A && C > B)
                {
                    return C == Math.Sqrt(A * A + B * B);
                }

                return false;
            }
        }

        #endregion

        #region [Constructor]
        
        public Triangle(double a, double b, double c) => (A, B, C) = (a, b, c);
        
        #endregion
    }
}
