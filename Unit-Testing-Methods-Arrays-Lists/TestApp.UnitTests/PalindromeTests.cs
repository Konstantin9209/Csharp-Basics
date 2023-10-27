using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> words = new() { "aha", "boabaob" };
       bool result = Palindrome.IsPalindrome(words);
        Assert.IsTrue(result);
        // Act

        // Assert
        //Assert.IsTrue(result);
    }

    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> words = new();
        bool result = Palindrome.IsPalindrome(words);
        Assert.IsTrue(result);
        // Act

        // Assert
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        List<string> words = new() { "aha" };
        bool result = Palindrome.IsPalindrome(words);
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        List<string> words = new() { "haha", "aha"};
        bool result = Palindrome.IsPalindrome(words);
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        List<string> words = new() { "Aha", "bOaBaoB" };
        bool result = Palindrome.IsPalindrome(words);
        Assert.IsTrue(result);
    }
}
