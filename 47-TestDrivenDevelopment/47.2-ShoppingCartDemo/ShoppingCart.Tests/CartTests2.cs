namespace ShoppingCart.Tests;

public class CartTests2
{
    private static CartManager _cartManager;    // usable in static methods: OneTimeSetUp and OneTimeTearDown
    private static CartItem _cartItem;          // usable in static methods: OneTimeSetUp and OneTimeTearDown

    // OneTimeSetUp is ClassInitialize in .NET Framework, Runs before test methods, uses static props and method
    [OneTimeSetUp]
    public static void Setup()
    {
        _cartManager = new();
        _cartItem = new(new() { Id = 1, Name = "Laptop", Price = 22890 }, 1);
        _cartManager.Add(_cartItem);
    }

    // OneTimeTearDown is TestCleanup, Runs after test methods
    [OneTimeTearDown]
    public static void Cleanup()
    {
        _cartManager.Clear();   // representative
    }

    [Test]
    public void Adding_Product_That_Cart_Does_Not_Contains_Should_Increase_Total_Quantity_And_Total_Count_By_1()
    {
        // Arrange
        int expectedTotalQuantity = _cartManager.TotalQuantity + 1;
        int expectedTotalItems = _cartManager.TotalItems + 1;

        // Act
        _cartManager.Add(new(new() { Id = 2, Name = "Keyboard", Price = 299 }, 1));

        // Assert
        Assert.That(_cartManager.TotalItems, Is.EqualTo(expectedTotalItems));
        Assert.That(_cartManager.TotalQuantity, Is.EqualTo(expectedTotalQuantity));
    }

    [Test]
    public void Adding_Product_That_Cart_Already_Contains_Should_Increase_Total_Quantity_But_Not_Total_Count()
    {
        // Arrange
        int expectedTotalQuantity = _cartManager.TotalQuantity + 1;
        int expectedTotalItem = _cartManager.TotalItems;

        // Act
        _cartManager.Add(_cartItem);    // * Fixed After Test Fail

        // Assert
        Assert.That(_cartManager.TotalQuantity, Is.EqualTo(expectedTotalQuantity));
        Assert.That(_cartManager.TotalItems, Is.EqualTo(expectedTotalItem));
    }
}
