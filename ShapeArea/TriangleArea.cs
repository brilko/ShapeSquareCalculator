namespace ShapeArea
{
    public class TriangleArea : IShapeAreaCalaculable, IIsRightTriangle
    {
        public TriangleArea(double sideA, double sideB, double sideC) 
        {
        
        }

        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public bool IsRightTriangle => throw new NotImplementedException();

        public double CalculateArea()
        {
            throw new NotImplementedException();
        }
    }
}
