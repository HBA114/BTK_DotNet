namespace ShoppingCart;

// TODO 1 : Adding product to cart
// TODO 2 : Removing  product from cart
// TODO 3 : Cleaning cart (removing all products from cart)
// TODO 4 : Adding product that cart already contains should increase total quantity, should not increase total count
// TODO 5 : Adding product that cart does not contains should increase total quantity and total count by 1

public class CartManager
{
    private readonly List<CartItem> _cartItems;

    public CartManager()
    {
        _cartItems = new List<CartItem>();
    }

    public void Add(CartItem cartItem)
    {
        CartItem? cartItemTemp = _cartItems.SingleOrDefault(x => x.Product.Id == cartItem.Product.Id);
        if (cartItemTemp is null)
        {
            _cartItems.Add(cartItem);
            return;
        }
        cartItemTemp.Quantity += cartItem.Quantity;
    }

    public void Remove(int id)
    {
        var product = _cartItems.FirstOrDefault(x => x.Product.Id == id);
        if (product is null) throw new NullReferenceException($"Product with id: {id} not found!");
        _cartItems.Remove(product);
    }

    public void Clear()
    {
        _cartItems.Clear();
    }

    public List<CartItem> CartItems
    {
        get => _cartItems;
    }

    public decimal TotalPrice
    {
        get => _cartItems.Sum(x => x.Product.Price * x.Quantity);
    }

    public int TotalQuantity
    {
        get => _cartItems.Sum(x => x.Quantity);
    }

    public int TotalItems
    {
        get => _cartItems.Count;
    }
}
