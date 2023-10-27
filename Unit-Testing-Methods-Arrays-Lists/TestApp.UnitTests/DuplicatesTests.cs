using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);
        Assert.That(result, Is.Empty);

        // Assert
    }

    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] numbers = new int[] { 1, 2, 3, 4, 5};
        int[] result = Duplicates.RemoveDuplicates(numbers);
        Assert.That(result, Is.EqualTo(numbers));
        // Act

        // Assert
        //Assert.That(result, Is.EqualTo(numbers));
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        int[] numbers = new int[] { 1, 1, 3, 3, 5, 5 };
        int[] result = Duplicates.RemoveDuplicates(numbers);
        Assert.That(result, Is.EqualTo(new int[] { 1, 3, 5}));
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        int[] numbers = new int[] { 1, 1, 1, 1, 1 };
        int[] result = Duplicates.RemoveDuplicates(numbers);
        Assert.That(result, Is.EqualTo(new int[] { 1 }));
    }
}
