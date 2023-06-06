using System.Diagnostics;
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

        Assert.AreEqual(expected: expected, actual: actual, message: $"Square Root of {inputValue} should be {expected}.");
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

        Assert.AreEqual(expected: expected, actual: actual, ignoreCase: true);
    }

    [TestMethod]
    public void TestMethod4()
    {
        const double notExpected = 0;
        var actual = Math.Pow(5, 0);

        Assert.AreNotEqual(notExpected: notExpected, actual: actual);
    }

    [TestMethod]
    public void TestMethod5()
    {
        var numbers = new byte[] { 1, 2, 3 };
        var otherNumbers = numbers;

        numbers[0] = 4;

        Assert.AreSame(expected: numbers, actual: otherNumbers);
    }

    [TestMethod]
    public void TestMethod6()
    {
        int a = 10;
        int b = a;

        //! Assert.AreSame failed. Do not pass value types to AreSame().
        // Assert.AreSame(expected: a, actual: b, message: "AreSame Failed");
        Assert.AreEqual(expected: a, actual: b, message: "AreEqual Failed");
        Assert.AreNotSame(notExpected: a, actual: b, message: "AreNotSame Failed");
    }

    [TestMethod]
    public void TestMethod7()
    {
        Assert.AreEqual(expected: 1, actual: 1);
        Assert.Inconclusive("This test is not sufficient");
    }

    [TestMethod]
    public void TestMethod8()
    {
        var number = 5m;

        Assert.IsInstanceOfType(value: number, expectedType: typeof(decimal));
        Assert.IsNotInstanceOfType(value: number, wrongType: typeof(int));
    }

    [TestMethod]
    public void TestMethod9()
    {
        Assert.IsTrue(condition: 10 % 2 == 0);
        Assert.IsFalse(condition: 10 % 2 == 1);
    }

    [TestMethod]
    public void TestMethod10()
    {
        List<string> names = new() { "Hasan", "Mustafa", "Ahmet" };

        var firstNameStartsWithLetterH = names.FirstOrDefault(x => x.StartsWith("H"));
        var firstNameStartsWithLetterB = names.FirstOrDefault(x => x.StartsWith("B"));

        Assert.IsNull(value: firstNameStartsWithLetterB, message: "IsNull Failed!");
        Assert.IsNotNull(value: firstNameStartsWithLetterH, message: "IsNotNull Failed!");
    }

    [TestMethod]
    public void TestMethod11()
    {
        try
        {
            var number = 5;
            int result = number / 0;
        }
        catch (DivideByZeroException ex)
        {
            Assert.Fail(message: $"Test Failed, Error message was: {ex.Message}");
        }
    }
}
