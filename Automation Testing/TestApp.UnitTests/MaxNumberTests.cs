using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{
    [Test]
    public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> nullList = null;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => MaxNumber.FindMax(nullList));
    }

    [Test]
    public void Test_FindMax_InputIsEmptyList_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> emptyList = new();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => MaxNumber.FindMax(emptyList));
    }

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        List<int>? ints = new List<int> { 5 };
        int result = MaxNumber.FindMax(ints);
        Assert.That(result, Is.EqualTo(5));

    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        List<int> ints = new List<int> { 5, 9, 4, 3 };
        int result = MaxNumber.FindMax(ints);
        Assert.That(result, Is.EqualTo(9));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        List<int> ints = new List<int> { -8, -4, -1, -5 };
        int result = MaxNumber.FindMax(ints);

        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        List<int> ints = new List<int> { -1, 8, -8, 9, -10, 10 };
        int result = MaxNumber.FindMax(ints);
        Assert.That(result, Is.EqualTo(10));

    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        List<int> ints = new List<int> { -5, 8, -5, 8, 11, 1, 11 };
        int result = MaxNumber.FindMax(ints);
        Assert.That(result, Is.EqualTo(11));

    }
}
