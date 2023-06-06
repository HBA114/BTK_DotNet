namespace TestContextDemo.Tests;

[TestClass]
public class UnitTest1
{
    public TestContext TestContext { get; set; }

    [ClassInitialize]
    public static void ClassInitialize(TestContext testContext)
    {
        testContext.WriteLine("--ClassInitialize--");
        testContext.WriteLine($"Test Name: {testContext.TestName}");
        testContext.WriteLine($"Test Situation: {testContext.CurrentTestOutcome}");
    }

    [TestInitialize]
    public void TestInitialize()
    {
        TestContext.WriteLine("--TestInitialize--");
        TestContext.WriteLine($"Test Name: {TestContext.TestName}");
        TestContext.WriteLine($"Test Situation: {TestContext.CurrentTestOutcome}");
        TestContext.Properties["info"] = "This is extra info";
    }

    [TestCleanup]
    public void TestCleanup()
    {
        TestContext.WriteLine("--TestCleanup--");
        TestContext.WriteLine($"Test Name: {TestContext.TestName}");
        TestContext.WriteLine($"Test Situation: {TestContext.CurrentTestOutcome}");
        TestContext.WriteLine($"Test Info: {TestContext.Properties["info"]}");
    }

    [TestMethod]
    public void TestMethod1()
    {
        TestContext.WriteLine("--TestMethod1--");
        TestContext.WriteLine($"Test Name: {TestContext.TestName}");
        TestContext.WriteLine($"Test Situation: {TestContext.CurrentTestOutcome}");
        TestContext.WriteLine($"Test Class: {TestContext.FullyQualifiedTestClassName}");

        Assert.AreEqual(expected: 1, actual: 1);
    }
}
