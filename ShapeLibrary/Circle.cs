namespace ShapeLibrary
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double GetArea() => Radius * Radius * 3.14;
        public override double GetPerimeter() => Radius * 2 * 3.14;

    }
}
