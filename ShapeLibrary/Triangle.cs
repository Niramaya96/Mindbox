namespace ShapeLibrary
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public bool CheckRightTriangle()
        {
            bool firstCase = SideA * SideA + SideB * SideB == SideC * SideC;
            bool secondCase = SideA * SideA + SideC * SideC == SideB * SideB;
            bool thirdCase = SideC * SideC + SideB * SideC == SideA * SideA;

            if (firstCase || secondCase || thirdCase)
                return true;
            return false;

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
