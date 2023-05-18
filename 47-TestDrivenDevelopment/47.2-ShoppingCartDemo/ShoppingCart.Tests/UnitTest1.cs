namespace ShoppingCart.Tests;

[TestClass]
public class UnitTest1
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
    public void AddingProductToCart()
    {
        int expected = 1;
        // Assert
        Assert.AreEqual(expected: expected, actual: _cartManager.TotalItems);
    }

    [TestMethod]
    public void RemovingProductFromCartTest()
    {
        int expectedCartItemCount = _cartManager.TotalItems - 1;

        // Act
        _cartManager.Remove(1);

        int cartItemCountAfterRemove = _cartManager.TotalItems;

        // Assert
        Assert.AreEqual(expected: expectedCartItemCount, actual: cartItemCountAfterRemove);
    }

    [TestMethod]
    public void CleaningCartTest()
    {
        // Act
        _cartManager.Clear();

        // Assert
        Assert.AreEqual(expected: 0, actual: _cartManager.TotalItems);
        Assert.AreEqual(expected: 0, actual: _cartManager.TotalQuantity);
    }
}
