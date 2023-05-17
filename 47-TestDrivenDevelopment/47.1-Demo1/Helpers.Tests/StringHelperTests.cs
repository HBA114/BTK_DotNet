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
        var s = "    Hasan  ";
        var expected = "Hasan";

        // Act
        var actual = StringHelper.RemoveUnnecessarySpaces(s);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }


    [Test]
    public void RemoveUnnecessarySpacesInBetweenWords()
    {
        // Arrange
        var s = "Hasan     Basri";
        var expected = "Hasan Basri";

        // Act
        var actual = StringHelper.RemoveUnnecessarySpaces(s);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
