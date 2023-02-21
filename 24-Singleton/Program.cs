
var customerManager = CustomerManager.CreateAsSingleton();

customerManager.Save();

public class CustomerManager
{
    static CustomerManager? _customerManager;
    private CustomerManager()
    {

    }
    public static CustomerManager CreateAsSingleton()
    {
        return _customerManager ?? (_customerManager = new CustomerManager());
        
        /*
        if (_customerManager == null)
        {
            _customerManager = new CustomerManager();
        }

        return _customerManager;
        */
    }
    public void Save()
    {
        Console.WriteLine($"Customer Saved Successfully");
    }
}