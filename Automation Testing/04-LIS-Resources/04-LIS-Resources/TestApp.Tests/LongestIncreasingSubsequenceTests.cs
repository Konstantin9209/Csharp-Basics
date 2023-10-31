using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        int[] arr = null;

        Assert.Throws<ArgumentNullException>(() => LongestIncreasingSubsequence.GetLis(arr));
    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        int[] arr = Array.Empty<int>();

        string result = LongestIncreasingSubsequence.GetLis(arr);

        Assert.AreEqual("", result);
    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        int[] arr = { 5 };

        string result = LongestIncreasingSubsequence.GetLis(arr);

        Assert.AreEqual("5", result);
    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {
        int[] arr = { 3, 10, 2, 1, 20 };

        string result = LongestIncreasingSubsequence.GetLis(arr);

        Assert.AreEqual("3 10 20", result);
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        string result = LongestIncreasingSubsequence.GetLis(arr);

        Assert.AreEqual("1 2 3 4 5", result);
    }
}
