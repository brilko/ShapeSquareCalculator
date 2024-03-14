using Shouldly;

namespace Tests.RoundSquare_Tests
{
    public class RoundArea_Creation_Tests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-2)]
        [InlineData(-1.5)]
        public void RoundSquare_CalculateSquare_TryConstructingWithNonPositiveRadius_ReturnValidationEror(double radius)
        {
            Assert.Throws<ValidationException>(() => new RoundArea(radius));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(2.5)]
        public void RoundSquare_CalculateSquare_ConstructingWithPositiveRadius_ReturnRoundWithCorrectRadius(
            double radius)
        {
            //Arrange
            var round = new RoundArea(radius);
            //Act
            var actualRadius = round.Radius;
            //Assert
            actualRadius.ShouldBe(radius);
        }
    }
}
