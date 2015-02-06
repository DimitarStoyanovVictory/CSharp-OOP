namespace BasicShapes
{
    class Rectangle : BasicShape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {
        }
        public override double CalculateArea()
        {
            return (this.Width * this.Width);
        }
        public override double CalcualtePerimeter()
        {
            return (this.Width * 2) + (this.Height * 2);
        }
    }
}
