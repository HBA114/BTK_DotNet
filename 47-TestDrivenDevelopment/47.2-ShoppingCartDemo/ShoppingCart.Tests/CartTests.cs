namespace ShoppingCart.Tests;

public class CartTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AddingProductToCartTest()
    {
        // Arrange
        const int expected = 1;

        CartManager cartManager = new();
        CartItem cartItem = new(new() { Id = 1, Name = "Laptop", Price = 22890 }, 1);

        // Act
        cartManager.Add(cartItem);
        var cartItemCount = cartManager.TotalItems;

        // Assert
        Assert.That(cartItemCount, Is.EqualTo(expected));   // constraint model
        // Assert.AreEqual(expected, cartItemCount);        // classic model
    }

    [Test]
    public void RemovingProductFromCartTest()
    {
        // Arrange
        CartManager cartManager = new();
        CartItem cartItem = new(new() { Id = 1, Name = "Laptop", Price = 22890 }, 1);

        cartManager.Add(cartItem);

        int cartItemCount = cartManager.TotalItems;

        // Assert
        cartManager.Remove(1);

        int cartItemCountAfterRemove = cartManager.TotalItems;
        Assert.That(cartItemCountAfterRemove, Is.EqualTo(cartItemCount - 1));
    }

    [Test]
    public void CleaningCartTest()
    {
        // Arrange
        CartManager cartManager = new();
        CartItem cartItem = new(new() { Id = 1, Name = "Laptop", Price = 22890 }, 1);

        // Act
        cartManager.Clear();

        // Assert
        Assert.That(cartManager.TotalItems, Is.EqualTo(0));
        Assert.That(cartManager.TotalQuantity, Is.EqualTo(0));
    }
}
