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
        var emptyArray = Array.Empty<int>();

        // Act
        int[] actualResult = Duplicates.RemoveDuplicates(emptyArray);
        var expectedResult = Array.Empty<int>();

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        var noDuplicatesArray = new int[] { 1, 2, 3, 4 };

        // Act
        int[] actualResult = Duplicates.RemoveDuplicates(noDuplicatesArray);
        var expectedResult = new int[] { 1, 2, 3, 4 };

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
        Assert.That(actualResult.Length == expectedResult.Length);
        Assert.That(actualResult[1] == expectedResult[1]);
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        // Arrange
        var someDuplicatesArray = new int[] { 2, 2, 3, 3, 5, 7 };

        // Act
        int[] actualResult = Duplicates.RemoveDuplicates(someDuplicatesArray);
        var expectedResult = new int[] { 2, 3, 5, 7 };

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        // Arrange
        var allDuplicatesArray = new int[] { 2, 2, 2, 2, 2 };

        // Act
        int[] actualResult = Duplicates.RemoveDuplicates(allDuplicatesArray);
        var expectedResult = new int[] { 2 };

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}