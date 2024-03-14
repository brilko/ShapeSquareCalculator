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
        public void RoundArea_Creation_NonPositiveRadius_ReturnValidationEror(double radius)
        {
            Assert.Throws<ArgumentException>(() => new RoundArea(radius));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(2.5)]
        public void RoundArea_Creation_PositiveRadius_ReturnRoundWithCorrectRadius(
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
