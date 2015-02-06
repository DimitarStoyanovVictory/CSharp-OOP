using System;

namespace BasicShapes
{
    class Triangle : BasicShape
    {
        private double a;
        private double b; 
        private double c; 
        public Triangle(double downSide, double heightDownSide, double angleAlpha)
            : base(downSide, heightDownSide)
        {
            this.AngleAlpha = angleAlpha;
        }
        public double AngleAlpha { get; set; }
        public override double CalculateArea()
        {
            return (this.Width * this.Height) / 2;
        }
        public override double CalcualtePerimeter()
        {
            a = this.Width; //This is side a
            b = this.Height / Math.Sin(this.AngleAlpha); //With sinus we find left side (b)
            c = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2) - (2 * b * c * Math.Cos(this.AngleAlpha))); //With cosinus teoremi you find side(c)
            return b + c + c;
        }
    }
}
