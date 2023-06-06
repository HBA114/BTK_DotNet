using System.Collections;
namespace CollectionAsserts.Tests;

[TestClass]
public class UnitTest1
{
    private List<string>? _users;

    [TestInitialize]
    public void InitializeData()
    {
        _users = new List<string>();

        _users.Add("Hasan");
        _users.Add("Mustafa");
        _users.Add("Ahmet");
    }

    [TestMethod]
    public void ElementsAndSortShouldBeEqual()
    {
        List<string> newUsers = new List<string>();

        newUsers.Add("Hasan");
        newUsers.Add("Mustafa");
        newUsers.Add("Ahmet");

        CollectionAssert.AreEqual(expected: _users, actual: newUsers);
    }

    [TestMethod]
    public void ElementsShouldBeSameSortCanBeDifferent()
    {
        List<string> newUsers = new List<string>();

        newUsers.Add("Mustafa");
        newUsers.Add("Ahmet");
        newUsers.Add("Hasan");

        CollectionAssert.AreEquivalent(expected: _users, actual: newUsers);
    }

    [TestMethod]
    public void ElementsOrSortShouldBeDifferent()
    {
        List<string> newUsers = new List<string>();

        newUsers.Add("Mustafa");
        newUsers.Add("Hasan");
        newUsers.Add("Ahmet");

        CollectionAssert.AreNotEqual(notExpected: _users, actual: newUsers);
    }

    [TestMethod]
    public void ElementsShouldBeDifferent()
    {
        List<string> newUsers = new List<string>();

        newUsers.Add("Hasan");
        newUsers.Add("Mustafa");
        newUsers.Add("Ahmet");
        newUsers.Add("Basri");

        CollectionAssert.AreNotEquivalent(expected: _users, actual: newUsers);
    }

    [TestMethod]
    public void ElementsShouldNotBeNull()
    {
        CollectionAssert.AllItemsAreNotNull(collection: _users);
    }

    [TestMethod]
    public void ElementsShouldBeUnique()
    {
        CollectionAssert.AllItemsAreUnique(collection: _users);
    }

    [TestMethod]
    public void AllElementsShouldBeSameType()
    {
        ArrayList list = new() { "Hasan", "Mustafa", "Ahmet" };

        CollectionAssert.AllItemsAreInstancesOfType(collection: list, expectedType: typeof(string));
    }

    [TestMethod]
    public void IsSubSetOfTest()
    {
        List<string> newUsers = new() { "Hasan", "Mustafa" };
        List<string> oldUsers = new() { "Basri", "Ahmet" };

        CollectionAssert.IsSubsetOf(subset: newUsers, superset: _users);
        CollectionAssert.IsNotSubsetOf(subset: oldUsers, superset: _users);
    }

    [TestMethod]
    public void ContainsTest()
    {
        CollectionAssert.Contains(collection: _users, element: "Hasan");
        CollectionAssert.DoesNotContain(collection: _users, element: "Basri");
    }
}
