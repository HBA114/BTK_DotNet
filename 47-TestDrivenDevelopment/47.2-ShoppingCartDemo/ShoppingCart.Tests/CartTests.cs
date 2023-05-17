namespace ShoppingCart.Tests;

public class CartTests
{
    private CartManager _cartManager;
    private CartItem _cartItem;

    // TestInitialize in .NET Framework, Runs before all individually test methods
    // example: runs before AddingProductToCartTest method, then runs before RemovingProductFromCartTest method
    [SetUp]
    public void Setup()
    {
        _cartManager = new();
        _cartItem = new(new() { Id = 1, Name = "Laptop", Price = 22890 }, 1);
        _cartManager.Add(_cartItem);
    }

    // Runs after all individually test methods
    // example: runs after AddingProductToCartTest method, then runs after RemovingProductFromCartTest method
    [TearDown]
    public void Cleanup()
    {
        _cartManager.Clear();   // representative
    }

    [Test]
    public void AddingProductToCartTest()
    {
        // Arrange
        const int expected = 1;

        // Act
        var cartItemCount = _cartManager.TotalItems;

        // Assert
        Assert.That(cartItemCount, Is.EqualTo(expected));   // constraint model
        // Assert.AreEqual(expected, cartItemCount);        // classic model
    }

    [Test]
    public void RemovingProductFromCartTest()
    {
        int cartItemCount = _cartManager.TotalItems;

        // Act
        _cartManager.Remove(1);

        int cartItemCountAfterRemove = _cartManager.TotalItems;

        // Assert
        Assert.That(cartItemCountAfterRemove, Is.EqualTo(cartItemCount - 1));
    }

    [Test]
    public void CleaningCartTest()
    {

        // Act
        _cartManager.Clear();

        // Assert
        Assert.That(_cartManager.TotalItems, Is.EqualTo(0));
        Assert.That(_cartManager.TotalQuantity, Is.EqualTo(0));
    }
}
