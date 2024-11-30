class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, string street, string city, string state, string country)
    {
        _name = name;
        _address = new Address(street, city, state, country);
    }
    public string GetName()
    {
        return _name;
    }
    public bool LivingInUSA()
    {
        return _address.IsInUSA();
    }
    public string ShowAddress()
    {
        return _address.ShowAddress();
    }
}