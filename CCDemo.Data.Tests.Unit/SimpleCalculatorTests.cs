namespace CCDemo.Data.Tests.Unit
{
    public class SimpleCalculatorTests
    {
        private readonly SimpleCalculator _sut = new();

        [Fact]
        public void AddTwo_AddsTwoToTheInput()
        {
            // Arrange
            int input = 4;
            int expectedOutput = 6;

            // Act
            int output = _sut.AddTwo(input);

            // Assert
            Assert.Equal(expectedOutput, output);
        }
    }
}
