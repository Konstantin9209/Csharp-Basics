using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_NullInput_ThrowsException()
    {
        // Arrange
        char[]? input = null;

        Assert.That(() => Fake.RemoveStringNumbers(input), Throws.ArgumentException);
    }

    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        char[] input = new char[] { '0', '1', 'a', 'b' };
        char[] result = Fake.RemoveStringNumbers(input);
        Assert.That(result, Is.EqualTo(new char[] { 'a', 'b' }));
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        char[] input = new char[] { 'c', 'd', 'a', 'b' };
        char[] result = Fake.RemoveStringNumbers(input);
        Assert.That(result, Is.EqualTo(input));
        }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        char[] input = Array.Empty<char>();
        char[] result = Fake.RemoveStringNumbers(input);
        Assert.That(result, Is.EqualTo(new char[] { }));
    }
}

