using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class BalancedBracketsTests
{
    [Test]
    public void Test_IsBalanced_EmptyInput_ShouldReturnTrue()
    {
        string[] input = Array.Empty<string>();
        bool expected = true;

        bool result = BalancedBrackets.IsBalanced(input);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_IsBalanced_BalancedBrackets_ShouldReturnTrue()
    {
        string[] input = new string[] { "(", ")" };
        bool expected = true;

        bool result = BalancedBrackets.IsBalanced(input);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_IsBalanced_UnbalancedBrackets_ShouldReturnFalse()
    {
        string[] input = new string[] { ")", ")" };
        bool expected = false;

        bool result = BalancedBrackets.IsBalanced(input);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_IsBalanced_MoreClosingBrackets_ShouldReturnFalse()
    {
        string[] input = new string[] { "(", ")", ")", ")" };
        bool expected = false;

        bool result = BalancedBrackets.IsBalanced(input);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_IsBalanced_NoClosingBrackets_ShouldReturnFalse()
    {
        string[] input = new string[] { "(" };
        bool expected = false;

        bool result = BalancedBrackets.IsBalanced(input);

        Assert.AreEqual(expected, result);
    }
}
