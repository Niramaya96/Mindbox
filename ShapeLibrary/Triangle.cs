namespace ShapeLibrary
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public bool IsRightTriangle { get; set; }



        public bool CheckRightTriangle()
        {

        }
        public override double GetArea()
        {
            double p = (SideA + SideB + SideC) / 2d;
            double area = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            return area;
        }

        public override double GetPerimeter() => SideA + SideB + SideC;
        
    }
}
