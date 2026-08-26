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

        [Fact]
        public void SubtractThree_SubtractsThreeFromTheInput()
        {
            int input = 4;
            int expectedOutput = 1;

            int output = _sut.SubtractThree(input);

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void MultiplyByTwo_MultipliesTheInputByTwo()
        {
            int input = 4;
            int expectedOutput = 8;

            int output = _sut.MultiplyByTwo(input);

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void DivideByTwo_DividesTheInputByTwo()
        {
            int input = 4;
            int expectedOutput = 2;

            int output = _sut.DivideByTwo(input);

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void DivideByTwo_ThrowsArgumentException_WhenInputIsZero()
        {
            int input = 0;

            Assert.Throws<ArgumentException>(() => _sut.DivideByTwo(input));
        }
        [Fact]
        public void IsEven_ReturnsTrue_WhenInputIsEven()
        {
            int input = 4;

            bool output = _sut.IsEven(input);

            Assert.True(output);
        }

        [Fact]
        public void IsEven_ReturnsFalse_WhenInputIsOdd()
        {
            int input = 1;

            bool output = _sut.IsEven(input);

            Assert.False(output);
        }
    }
   
}

    


