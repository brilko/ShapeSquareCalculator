namespace Tests.RoundSquare_Tests
{
    public class RoundSquare_Creation_Tests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-2)]
        [InlineData(-1.5)]
        public void RoundSquare_CalculateSquare_ReturnErorWhileConstructingNonPositiveRadius(double radius)
        {
            Assert.Throws<ValidationException>(() => new RoundSquare(radius));
        }
    }
}
