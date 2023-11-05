using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class CharacterRangeTests
{
    [Test]
    public void Test_GetRange_WithAAndBInOrder_ReturnsEmptyString()
    {
        char firstChar = 'a';
        char secondChar = 'b';
        string expected = "";

        string result = CharacterRange.GetRange(firstChar, secondChar);

            Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetRange_WithBAndAInOrder_ReturnsEmptyString()
    {
        char firstChar = 'a';
        char secondChar = 'b';
        string expected = "";

        string result = CharacterRange.GetRange(secondChar, firstChar);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetRange_WithAAndCInOrder_ReturnsB()
    {
        char firstChar = 'a';
        char secondChar = 'c';
        string expected = "b";

        string result = CharacterRange.GetRange(firstChar, secondChar);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetRange_WithDAndGInOrder_Returns_E_F()
    {
        char firstChar = 'd';
        char secondChar = 'g';
        string expected = "e f";

        string result = CharacterRange.GetRange(firstChar, secondChar);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetRange_WithXAndZInOrder_Returns_Y()
    {
        char firstChar = 'x';
        char secondChar = 'z';
        string expected = "y";

        string result = CharacterRange.GetRange(firstChar, secondChar);

        Assert.AreEqual(expected, result);
    }
}
