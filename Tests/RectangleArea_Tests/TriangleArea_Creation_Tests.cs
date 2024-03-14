using Shouldly;

namespace Tests.RectangleArea_Tests
{
    public class TriangleArea_Creation_Tests
    {
        [Theory]
        [InlineData(1.5, 1.5, 1.5)]
        [InlineData(1.75, 1.75, 1.75)]
        [InlineData(2, 2, 2)]
        public void TriangleArea_Creation_PositiveDoubleSides_EqualSides(
            double sideA, double sideB, double sideC) 
        {
            var triangle = new TriangleArea(sideA, sideB, sideC);
            triangle.SideA.ShouldBe(sideA);
            triangle.SideB.ShouldBe(sideB);
            triangle.SideC.ShouldBe(sideC);
        }

        [Fact]
        public void TriangleArea_Creation_NonPositiveSides_RaiseError()
        {
            foreach (var sides in CreateSidesWithNonPositiveLength())
            {
                if (sides.Item1 == 1 || sides.Item2 == 1 || sides.Item3 == 1)
                    continue;
                Assert.Throws<ArgumentException>(
                    () => new TriangleArea(sides.Item1, sides.Item2, sides.Item3));
            }
        }

        private IEnumerable<Tuple<double, double, double>> CreateSidesWithNonPositiveLength() 
        {
            for (double sideA = -1; sideA <= 1; sideA++)
                for (double sideB = -1; sideB <= 1; sideB++)
                    for (double sideC = -1; sideC <= 1; sideC++)
                        yield return Tuple.Create(sideA, sideB, sideC);
        }

        [Theory]
        [InlineData(1, 1, 10)]
        [InlineData(1, 2, 10)]
        [InlineData(1, 9, 11)]
        public void TriangleArea_Creation_SidesNotFolowTriangleInequality_ThrowError(
            double side1, double side2, double side3) 
        {
            foreach (var (sideA, sideB, sideC) in SidesTransformer.Transform(side1, side2, side3))
                Assert.Throws<ArgumentException>(() => new TriangleArea(sideA, sideB, sideC));
        }
    }
}
