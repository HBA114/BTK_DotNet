namespace Asserts.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        const double inputValue = 16;
        const double expected = 4;

        double actual = Math.Sqrt(inputValue);

        Assert.AreEqual(expected: expected, actual: actual, $"Square Root of {inputValue} should be {expected}.");
    }

    [TestMethod]
    public void TestMethod2()
    {
        double expected = 3.1622;
        double delta = 0.0001;

        double actual = Math.Sqrt(10);

        // Formula: |expected - actual| <= delta

        Assert.AreEqual(expected: expected, actual: actual, delta: delta);
    }

    [TestMethod]
    public void TestMethod3()
    {
        string expected = "HELLO";
        string actual = "hello";

        Assert.AreEqual(expected: expected, actual: actual, true);
    }

    [TestMethod]
    public void TestMethod4()
    {
        const double notExpected = 0;
        var actual = Math.Pow(5, 0);

        Assert.AreNotEqual(notExpected: notExpected, actual: actual);
    }
}
