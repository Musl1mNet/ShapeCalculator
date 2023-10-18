namespace ShapeCalculator.Models
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (IsTriangleValid(sideA, sideB, sideC))
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;
            }
            else
            {
                throw new ArgumentException("Invalid triangle sides.");
            }
        }

        public static bool IsTriangleValid(double sideA, double sideB, double sideC)
        {
            return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
        }

        public double CalculateArea()
        {
            // Heron's formula to calculate the area of a triangle
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}

