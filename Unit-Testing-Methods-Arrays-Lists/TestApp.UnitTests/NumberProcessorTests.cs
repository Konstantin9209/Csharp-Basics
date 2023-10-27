using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class NumberProcessorTests
{
    [Test]
    public void Test_ProcessNumbers_SquareEvenNumbers()
    {
        // Arrange
        List<int> input = new() { 2, 4, 6 };
        List<double> expected = new() { 4, 16, 36 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ProcessNumbers_SquareRootOddNumbers()
    {
        List<int> input = new() { 9, 25, 49 };
        List<double> expected = new() { 3, 5, 7 };

        List<double> actual = NumberProcessor.ProcessNumbers(input);
        CollectionAssert.AreEqual(expected, actual);
  
    }


    [Test]
    public void Test_ProcessNumbers_HandleZero()
    {

        List<int> input = new() { 0 };
        List<int> expected = new() { 0 };
        List<double> actual = NumberProcessor.ProcessNumbers(input);

    }

    [Test]
    public void Test_ProcessNumbers_HandleNegativeNumbers()
    {
        List<int> input = new() { -3 };
      Assert.That(() => NumberProcessor.ProcessNumbers(input), Throws.ArgumentException);
    }

    [Test]
    public void Test_ProcessNumbers_EmptyInput()
    {
        List<int> input = new();
        List<int> expected = new() { 0 };
        List<double> actual = NumberProcessor.ProcessNumbers(input);
    }
}
