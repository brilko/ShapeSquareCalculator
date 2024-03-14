namespace ShapeArea
{
    public class RoundArea : IShapeAreaCalaculable
    {
        public RoundArea(double radius) 
        {
        
        }

        public double Radius { get; }

        public double CalculateArea()
        {
            throw new NotImplementedException();
        }
    }
}
