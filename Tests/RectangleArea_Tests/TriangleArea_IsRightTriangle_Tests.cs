using Shouldly;

namespace Tests.RectangleArea_Tests
{
    public class TriangleArea_IsRightTriangle_Tests
    {
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 2.5, 3)]
        [InlineData(1, 1.25, 1.33)]
        public void TriangleArea_IsRightTriangle_TriangleNotRight_ReturnFalse(
            double side1, double side2, double side3) 
        {
            CheckTriangleRight(side1, side2, side3, false);
        }


        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(1, 1, 1.414213562373095)]
        [InlineData(1.772453, 1.648721, 0.650623)]
        public void TriangleArea_IsRightTriangle_TriangleIsRight_ReturnTrue(
            double side1, double side2, double side3)
        {
            CheckTriangleRight(side1, side2, side3, true);
        }

        private void CheckTriangleRight(double side1, double side2, double side3, bool expectedIsRight) 
        {
            foreach (var (sideA, sideB, sideC) in SidesTransformer.Transform(side1, side2, side3))
            {
                //Arrange
                var triangle = new TriangleArea(sideA, sideB, sideC);
                //Act
                var actualIsRight = triangle.IsRight(0.01);
                //Assert
                actualIsRight.ShouldBe(expectedIsRight);
            }
        }
    }
}
