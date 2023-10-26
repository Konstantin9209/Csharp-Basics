using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{

    [Test]
    public void Test_Sum_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => AdjacentEqual.Sum(nullList));
    }


    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        string result = AdjacentEqual.Sum(emptyList);


        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> ints = new List<int> { 1, 2, 3, 4, 5 };

        // Act
        string result = AdjacentEqual.Sum(ints);

        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 4 5"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        List<int> ints = new List<int> { 1, 2, 2, 4, 5 };
        string result = AdjacentEqual.Sum(ints);
        Assert.That(result, Is.EqualTo("1 8 5"));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        List<int> ints = new List<int> { 2, 2, 4 };
        string result = AdjacentEqual.Sum(ints);
        Assert.That(result, Is.EqualTo("8"));

    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        List<int> ints = new List<int> { 1, 1, 2, 3, 4 };
        string result = AdjacentEqual.Sum(ints);
        Assert.That(result, Is.EqualTo("4 3 4"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        List<int> intd = new List<int> { 1, 2, 3, 4, 2, 2 };
        string resultNew = AdjacentEqual.Sum(intd);
        Assert.That(resultNew, Is.EqualTo("1 2 3 8"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        List<int> ints = new List<int> { 1, 2, 2, 4, 9, 10 };
        string resulted = AdjacentEqual.Sum(ints);
        Assert.That(resulted, Is.EqualTo("1 8 9 10"));
    }
}
