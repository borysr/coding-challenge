using System;
using System.Collections.Generic;
using CodingChallenge.Lib;
using Xunit;

namespace CodingChallenge.Tests
{
  public class MixLibTests
  {
    [Fact]
    public void SumTwo_1_Test()
    {
      // arrange 
      int target = 5;
      List<int> inList = new List<int>(){1,2,4,5,8,9,17,23};
      List<int> expected = new List<int>(){0,2};
      // act
      var actual = MixLib.TwoSum(inList, target);

      // assert
      Assert.Equal(expected, actual);
    }

    [Fact]
    public void SumTwo_2_Test()
    {
      // arrange 
      int target = 17;
      List<int> inList = new List<int>(){3, 9, 2, 11, 8, 23};
      List<int> expected = new List<int>(){1,4};
      
      // act
      var actual = MixLib.TwoSum(inList, target);

      // assert
      Assert.Equal(expected, actual);

    }

    [Theory]
    [InlineData(0, "")]
    [InlineData(1, "")]
    [InlineData(2, "")]
    [InlineData(3, "fizz")]
    [InlineData(4, "")]
    [InlineData(5, "buzz")]
    [InlineData(6, "fizz")]
    [InlineData(7, "")]
    [InlineData(8, "")]
    [InlineData(9, "fizz")]
    [InlineData(10, "buzz")]
    [InlineData(15, "fizzbuzz")]

    public void FizzBuzz_Test(int number, string str)
    {
      // Arrange 
      var expected = str;

      // Act
      var actual = MixLib.FizzOrBuzz(number);

      // Assert
      Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("A", true)]
    [InlineData("mom", true)]
    [InlineData("racecar", true)]
    [InlineData("fizzbuzz", false)]
    [InlineData("12344321", true)]
    public void IsPalindrome_test(string str, bool result)
    {
      // Arrange 
      var expected = result;

      // Act
      var actual = MixLib.IsPalindrome(str);

      // Assert
      Assert.Equal(expected, actual);
    }

    #region Fibonacci Tests
    [Fact]
    public void Return_for_1()
    {
      // Arrange 
      List<int> expected = new List<int>() { 1 };

      // Act
      var actual = MixLib.FibonacciSequence(1);

      // Assert
      Assert.Equal(expected, actual);
      Assert.Equal(expected.Count, actual.Count);
    }
  [Fact]
    public void Return_for_2()
    {
      // Arrange 
      List<int> expected = new List<int>() { 1, 1 };

      // Act
      var actual = MixLib.FibonacciSequence(2);

      // Arrange
      Assert.Equal(expected, actual);
      Assert.Equal(expected.Count, actual.Count);
    }
    [Fact]
    public void Return_for_3()
    {
      // Arrange 
      List<int> expected = new List<int>() { 1, 1, 2 };

      // Act
      var actual = MixLib.FibonacciSequence(3);

      // Arrange
      Assert.Equal(expected, actual);
      Assert.Equal(expected.Count, actual.Count);
    }
    [Fact]
    public void Return_for_4()
    {
      // Arrange 
      List<int> expected = new List<int>() { 1, 1, 2, 3 };

      // Act
      var actual = MixLib.FibonacciSequence(4);

      // Arrange
      Assert.Equal(expected, actual);
      Assert.Equal(expected.Count, actual.Count);
    }
    [Fact]
    public void Return_for_5()
    {
      // Arrange 
      List<int> expected = new List<int>() { 1, 1, 2, 3, 5 };

      // Act
      var actual = MixLib.FibonacciSequence(5);

      // Arrange
      Assert.Equal(expected, actual);
      Assert.Equal(expected.Count, actual.Count);

      Assert.Equal(actual[actual.Count - 3], actual[actual.Count - 1] - actual[actual.Count - 2]);
    }
    [Fact]
    public void Return_for_12()
    {
      // Arrange 
      List<int> expected = new List<int>() { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };

      // Act
      var actual = MixLib.FibonacciSequence(12);

      // Arrange
      Assert.Equal(expected, actual);
      Assert.Equal(expected.Count, actual.Count);

      Assert.Equal(actual[actual.Count - 3], actual[actual.Count - 1] - actual[actual.Count - 2]);
    }
    #endregion
  }
}
