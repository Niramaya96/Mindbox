
namespace ShapeLibrary
{
    public class Rectangle : Shape
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public override double GetArea() => Width * Height;
        public override double GetPerimeter() => Width* 2 + Height* 2;
        
    }
}
