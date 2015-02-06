using System;

namespace BasicShapes
{
    class Circle : BasicShape
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double Radius { get; set; }
        public override double CalculateArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        public override double CalcualtePerimeter()
        {
            return Math.PI * 2 * this.Radius;
        }
    }
}
