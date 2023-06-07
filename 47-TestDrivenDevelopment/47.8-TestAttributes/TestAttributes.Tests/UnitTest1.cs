namespace TestAttributes.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    [Owner("Hasan")]
    [TestCategory("Tester")]
    [Priority(1)]
    [TestProperty("Updated", "Ali")]
    public void TestMethod1()
    {
        Assert.AreEqual(1, 1);
    }
    
    [TestMethod]
    [Owner("Hasan")]
    [TestCategory("Tester")]
    [Priority(1)]
    [TestProperty("Updated", "Ali")]
    [TestProperty("Updated2", "Kerem")]
    public void TestMethod2()
    {
        Assert.AreEqual(1, 1);
    }

    [TestMethod]
    [Owner("Hasan")]
    [TestCategory("Tester")]
    [TestCategory("Developer")]
    [Priority(1)]
    public void TestMethod3()
    {
        Assert.AreEqual(1, 1);
    }

    [TestMethod]
    [Owner("Basri")]
    [TestCategory("Developer")]
    [Priority(2)]
    public void TestMethod4()
    {
        Assert.AreEqual(1, 1);
    }

    [TestMethod, Description("This is a test description")]
    [Owner("Basri")]
    [TestCategory("Developer")]
    [Priority(2)]
    public void TestMethod5()
    {
        Assert.AreEqual(1, 1);
    }

    [TestMethod, Ignore]
    [Owner("Basri")]
    [TestCategory("Developer")]
    [Priority(2)]
    public void TestMethod6()
    {
        Assert.AreEqual(1, 1);
    }

    [TestMethod, Timeout(1000)]
    [Owner("Basri")]
    [TestCategory("Developer")]
    [Priority(2)]
    public void TestMethod7()
    {
        Assert.AreEqual(1, 1);
    }

    [TestMethod, Timeout(TestTimeout.Infinite)]
    [Owner("Basri")]
    [TestCategory("Developer")]
    [Priority(2)]
    public void TestMethod8()
    {
        Thread.Sleep(1500);
        Assert.AreEqual(1, 1);
    }
}
