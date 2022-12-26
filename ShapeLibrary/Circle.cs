namespace ShapeLibrary
{
    public class Circle : Shape
    {
        public double Radius { get; private set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea() => Math.Round(Math.Pow(Radius,2) * Math.PI,2);

    }
}
