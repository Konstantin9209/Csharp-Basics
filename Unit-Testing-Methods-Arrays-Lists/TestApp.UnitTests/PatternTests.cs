using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_NullInput_ThrowsException()
    {
        int[] inputArray = null;
        Assert.Throws<ArgumentException>(() => Pattern.SortInPattern(inputArray));
    }

    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        int[] inputArray = { 1, 2, 1, 3, 4, 10, 12, 15 };
        int[] expectedOutput = { 1, 15, 2, 12, 3, 10, 4 };

        int[] result = Pattern.SortInPattern(inputArray);

        Assert.AreEqual(expectedOutput, result);
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        int[] inputArray = { };
        int[] expectedOutput = { };

        int[] result = Pattern.SortInPattern(inputArray);

        Assert.AreEqual(expectedOutput, result);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        int[] inputArray = { 5 };
        int[] expectedOutput = { 5 };

        int[] result = Pattern.SortInPattern(inputArray);

        Assert.AreEqual(expectedOutput, result);
    }
}
