// ArrayList();
List<string> list = new List<string>();
list.Add("listItem1");

List<Customer> customerList = new List<Customer>();

customerList.Add(new Customer { id = 1, firstName = "Hasan" });
customerList.Add(new Customer { id = 2, firstName = "Engin" });

foreach (var customer in customerList)
{
    Console.WriteLine("id : {0} , name : {1}", customer.id, customer.firstName);
}

Console.ReadLine();

static void ArrayList()
{
    // string[] cities = new string[2] { "Ankara", "Konya" };
    // this array have 2 values and cant add a 3rd value

    List<string> cities = new List<string> { "Ankara" };
    // this list can use as a array and you can add new items to list.
    cities.Add("Konya");
    cities.Add("İstanbul");
    cities.Add("Adana");
    cities.Add("İzmir");

    List<string> countries = new List<string>();

    countries.Add("Türkiye");
    countries.Add("Russia");
    countries.Add("England");


    foreach (var city in cities)
    {
        Console.WriteLine(city);
    }

    Console.WriteLine();

    foreach (var country in countries)
    {
        Console.WriteLine(country);
    }
}

class Customer
{
    public int id { get; set; }
    public string firstName { get; set; }

}