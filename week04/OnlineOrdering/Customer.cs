
public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA()
    {
        return _address.Country.ToLower() == "usa";
    }

    public string Name => _name;
    public Address Address => _address;
}