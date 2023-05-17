namespace Helpers.Tests;

public class StringHelperTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void RemoveStartAndEndSpacesTest()
    {
        // Arrange
        var s = "    Hello  ";
        var expected = "Hello";

        // Act
        var actual = StringHelper.RemoveUnnecessarySpaces(s);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }


    [Test]
    public void RemoveUnnecessarySpacesInBetweenWords()
    {
        // Arrange
        var s = "Hello     World";
        var expected = "Hello World";

        // Act
        var actual = StringHelper.RemoveUnnecessarySpaces(s);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
