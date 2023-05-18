using System.Diagnostics;
using System.Reflection;
namespace AssemblyLevel;

[TestClass]
public class UnitTest1
{
    [AssemblyInitialize]    // works one time before anything in this namespace, than runs tests
    public static void AssemblyInitialize(TestContext testContext)
    {
        Console.WriteLine("Assembly Initialize");
    }

    [AssemblyCleanup]       // works one time after all tests in namespace finished
    public static void AssemblyCleanup()
    {
        Console.WriteLine("Assembly Cleanup");
    }

    [ClassInitialize]       // works one time before tests starts for this class
    public static void ClassInitialize(TestContext testContext)
    {
        Console.WriteLine("Class Initialize");
    }

    [ClassCleanup]          // works one time after tests ends for this class
    public static void ClassCleanup()
    {
        Console.WriteLine("Class Cleanup");
    }

    [TestInitialize]        // works one time before each test method in this class
    public void TestInitialize()
    {
        Console.WriteLine("Test Initialize");
    }

    [TestCleanup]           // works one time after each test method in this class
    public void TestCleanup()
    {
        Console.WriteLine("Test Cleanup");
    }

    [TestMethod]
    public void TestMethod1()
    {
        Console.WriteLine("Test Method 1 ..............");
    }

    [TestMethod]
    public void TestMethod2()
    {
        Console.WriteLine("Test Method 2 ..............");
    }
}
