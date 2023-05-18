namespace ShoppingCart.Tests;

[TestClass]
public class UnitTest2
{
    private static CartManager _cartManager;
    private static CartItem _cartItem;

    [ClassInitialize]
    public static void ClassInitialize(TestContext testContext)
    {
        _cartItem = new(new(1, "Laptop", 1), 1);
        _cartManager = new();
        _cartManager.Add(_cartItem);
    }

    [ClassCleanup]
    public static void ClassCleanup()
    {
        _cartManager.Clear();
    }

    [TestMethod]
    public void Adding_Product_That_Cart_Does_Not_Contains_Should_Increase_Total_Quantity_And_Total_Count_By_1()
    {
        // Arrange
        int expectedTotalQuantity = _cartManager.TotalQuantity + 1;
        int expectedTotalItems = _cartManager.TotalItems + 1;

        // Act
        _cartManager.Add(new(new(2, "Keyboard", 299), 1));

        // Assert
        Assert.AreEqual(expected: expectedTotalItems, _cartManager.TotalItems);
        Assert.AreEqual(expected: expectedTotalQuantity, _cartManager.TotalQuantity);
    }

    [TestMethod]
    public void Adding_Product_That_Cart_Already_Contains_Should_Increase_Total_Quantity_But_Not_Total_Count()
    {
        // Arrange
        int expectedTotalQuantity = _cartManager.TotalQuantity + 1;
        int expectedTotalItem = _cartManager.TotalItems;

        // Act
        _cartManager.Add(_cartItem);    // * Fixed After Test Fail

        // Assert
        Assert.AreEqual(expected: expectedTotalItem, _cartManager.TotalItems);
        Assert.AreEqual(expected: expectedTotalQuantity, _cartManager.TotalQuantity);
    }

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException), AllowDerivedTypes = false)]  // if allow derived type is true, giving Exception Class type can pass test
    public void Trying_To_Remove_A_Product_That_Not_Exists_In_Cart_Should_Throw_NullReferenceException()
    {
        _cartManager.Remove(3);
    }
}
