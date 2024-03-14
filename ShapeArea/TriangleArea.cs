namespace ShapeArea
{
    public class TriangleArea : IShapeAreaCalaculable, IIsRightTriangle
    {
        public TriangleArea(double sideA, double sideB, double sideC) 
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("A triangle`s sides can`t be non positive");
            if (sideA >= sideB + sideC || sideB >= sideA + sideC || sideC >= sideA + sideB)
                throw new ArgumentException("A triangle`s sides must follow the triangle inequality");
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public bool IsRight(double tolerance = 0) 
        {
            if(tolerance < 0)
                throw new ArgumentException("A tolerance can`t be negative.");
            var a2 = SideA * SideA;
            var b2 = SideB * SideB; 
            var c2 = SideC * SideC;
            return IsRight(a2, b2, c2, tolerance) ||
                IsRight(b2, c2, a2, tolerance) ||
                IsRight(c2, a2, b2, tolerance);
        }

        private bool IsRight(double сathetus2_1, double сathetus2_2, double hypotenuse2, double tolerance)
        {
            var cathetuses2 = сathetus2_1 + сathetus2_2;
            return hypotenuse2 >= cathetuses2 - tolerance && hypotenuse2 <= cathetuses2 + tolerance;
        }

        public double CalculateArea() 
        {
            //Heron's formula
            var a2 = SideA * SideA;
            var b2 = SideB * SideB;
            var c2 = SideC * SideC;
            var a2b2c2 = a2 + b2 + c2;
            return 1.0 / 4.0 * Math.Sqrt(a2b2c2 * a2b2c2 - 2 * (a2 * a2 + b2 * b2 + c2 * c2));
        }
    }
}
