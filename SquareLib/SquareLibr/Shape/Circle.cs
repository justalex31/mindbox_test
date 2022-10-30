using System;

namespace SquareLibr
{
    public class Circle : Shape
    {
        #region [Field]
        
        private double r;

        #endregion

        #region [Properties]
        
        public double R
        {
            get => r;
            set
            {
                if (value < 0)
                    throw new ArgumentException($"Argument less thez zero.");

                r = value;
            }
        }

        public override double Area => Math.PI * R * R;

        #endregion

        #region [Constructor]

        public Circle(double r) => R = r;

        #endregion
    }
}
