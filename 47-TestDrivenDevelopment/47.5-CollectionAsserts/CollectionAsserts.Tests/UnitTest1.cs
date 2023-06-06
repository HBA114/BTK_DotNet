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
}
