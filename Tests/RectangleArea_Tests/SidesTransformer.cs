namespace Tests.RectangleArea_Tests
{
    internal static class SidesTransformer
    {
        public static IEnumerable<(double, double, double)> Transform(
            double side1, double side2, double side3) 
        {
            yield return (side1, side2, side3);
            yield return (side1, side3, side2);
            yield return (side2, side1, side3);
            yield return (side2, side3, side1);
            yield return (side3, side1, side2);
            yield return (side3, side2, side1);
        }
    }
}
