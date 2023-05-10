using TDDKataCalc;

namespace TDDKata
{
    public class UnitTest1
    {
        [Fact]
        public void EmptyArgumentShouldReturnZero()
        {
            // Arrange
            string digit = "";
            int expected = 0;
            // Act
            int actual = Calc.Add(digit);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void OneArgumentShouldReturnTheArgument()
        {
            // Arrange
            string digit = "1";
            int expected = 1;
            // Act
            int actual = Calc.Add(digit);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TwoArgumentsShouldReturnTheSumOfTheTwoNumbers()
        {
            // Arrange
            string digit = "1,2";
            int expected = 3;
            // Act
            int actual = Calc.Add(digit);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MultipleArgumentsShouldReturnTheSumOfAll()
        {
            // Arrange
            string digit = "1,2,3,4";
            int expected = 10;
            // Act
            int actual = Calc.Add(digit);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NullArgumentShouldReturnMinusOne()
        {
            // Arrange
            string digit = null;
            int expected = -1;
            // Act
            int actual = Calc.Add(digit);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InvalidArgumentShouldReturnMinusOne()
        {
            // Arrange
            string digit = "abc";
            int expected = -1;
            // Act
            int actual = Calc.Add(digit);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MultipleArgumentsWithMultipleCommasShouldReturnMinusOne()
        {
            // Arrange
            string digit = "1,,,2,,,3";
            int expected = -1;
            // Act
            int actual = Calc.Add(digit);
            // Assert
            Assert.Equal(expected, actual);
        }


    }
}