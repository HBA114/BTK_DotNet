using System.Text.RegularExpressions;

namespace StringAsserts.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void StringContainsTest()
    {
        StringAssert.Contains(value: "Hello world from dotnet tests", substring: "net");
    }

    [TestMethod]
    public void StringMatchesTest()
    {
        StringAssert.Matches(value: "Hello world from dotnet tests", pattern: new Regex(@"[a-zA-Z]"));
        StringAssert.DoesNotMatch(value: "Hello world from dotnet tests", pattern: new Regex(@"[0-9]"));
    }

    [TestMethod]
    public void StartsWithTest()
    {
        StringAssert.StartsWith(value: "Hello world from dotnet tests", substring: "Hello");
    }
    
    [TestMethod]
    public void EndsWithTest()
    {
        StringAssert.EndsWith(value: "Hello world from dotnet tests", substring: "tests");
    }
}
