using System.ComponentModel.DataAnnotations;

namespace ShapeArea
{
    public class RoundArea : IShapeAreaCalaculable
    {
        public RoundArea(double radius) 
        {
            if (radius <= 0)
                throw new ArgumentException("A round`s radius can`t be non positive.");
            Radius = radius;
        }

        public double Radius { get; }

        public double CalculateArea() => Math.PI * Radius * Radius;
    }
}
