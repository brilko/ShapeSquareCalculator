using Shouldly;

namespace Tests.RoundSquare_Tests
{
    public class RoundArea_CalculateSquare_Tests
    {
        [Theory]
        [InlineData(1, Math.PI)]
        [InlineData(2, 4 * Math.PI)]
        [InlineData(1.5, 2.25 * Math.PI)]
        public void RoundSquare_CalculateSquare_Raised_ReturnCorrectSquare(double radius, double expectedArea) 
        {
            //Arrange
            var round = new RoundArea(radius);
            //Act
            var actualArea = round.CalculateArea();
            //Assert
            actualArea.ShouldBe(expectedArea, 0.01);
        }
    }
}