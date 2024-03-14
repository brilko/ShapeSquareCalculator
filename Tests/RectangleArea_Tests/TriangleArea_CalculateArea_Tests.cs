using Shouldly;

namespace Tests.RectangleArea_Tests
{
    public class TriangleArea_CalculateArea_Tests
    {
        [Theory]
        [InlineData(1, 1, 1, 0.4330127018922193)]
        [InlineData(1, 1, 1.5, 0.49607837082461076)]
        [InlineData(1, 1.5, 2.3, 0.5499090833947008)]
        [InlineData(3, 4, 5, 6.0)]
        public void TriangleArea_CalculateArea_Raised_ReturnCorrectAreaInAnySideOrder(
            double side1, double side2, double side3, double expectedArea) 
        {
            foreach (var (sideA, sideB, sideC) in SidesTransformer.Transform(side1, side2, side3)) 
            {
                //Arrange
                var triangle = new TriangleArea(sideA, sideB, sideC);
                //Act
                var actualArea = triangle.CalculateArea();
                //Assert
                actualArea.ShouldBe(expectedArea, 0.1);
            }
        }
    }
}
