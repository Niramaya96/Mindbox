namespace ShapeLibrary
{
    public class Triangle : Shape
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public bool IsRectangular()
        {
            bool firstCase = SideA * SideA + SideB * SideB == SideC * SideC;
            bool secondCase = SideA * SideA + SideC * SideC == SideB * SideB;
            bool thirdCase = SideC * SideC + SideB * SideC == SideA * SideA;

            return firstCase || secondCase || thirdCase;
        }
        public override double GetArea()
        {
            double p = GetPerimeter() / 2d;
            double area = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            return Math.Round(area,2);
        }

        private double GetPerimeter() => SideA + SideB + SideC;
        
    }
}
