namespace AssemblyLevel;

[TestClass]
public class UnitTest2
{
    [ClassInitialize]
    public static void ClassInitialize(TestContext testContext)
    {
        Console.WriteLine("Class UnitTest2 Initialize");
    }

    [ClassCleanup]
    public static void ClassCleanup()
    {
        Console.WriteLine("Class UnitTest2 Cleanup");
    }

    [TestInitialize]
    public void TestInitialize()
    {
        Console.WriteLine("Test UnitTest2 Initialize");
    }

    [TestCleanup]
    public void TestCleanup()
    {
        Console.WriteLine("Test UnitTest2 Cleanup");
    }

    [TestMethod]
    public void TestMethod3()
    {
        Console.WriteLine("Test Method 3 ..............");
    }

    [TestMethod]
    public void TestMethod4()
    {
        Console.WriteLine("Test Method 4 ..............");
    }
}
