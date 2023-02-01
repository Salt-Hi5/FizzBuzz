using FluentAssertions; 
using Xunit; 

namespace FizzBuzzer;

public class FizzBuzzTester
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(3, "Fizz")]
    [InlineData(4, "4")]
    [InlineData(5, "Buzz")]
    [InlineData(15, "FizzBuzz")]
    public void Test1(int value, string result)
    {
        // Arrange
        var values = Enumerable.Range(1, 100).ToArray();

        // Act
        var resultArray = FizzBuzz.DoFizzBuzz(values);
        var resultValue = resultArray[value - 1];
        
        // Assert
        resultValue.Should().Be(result); 
    }
}