class Product
{
    private string _id;
    private string _name;
    private double _price;
    private int _quatity;
    public Product(string name, double price, int quantity)
    {
        _id = Guid.NewGuid().ToString();
        _name = name;
        _price = price;
        _quatity = quantity;
    }

    public string GetId()
    {
        return _id;
    }

    public string GetName()
    {
        return _name;
    }
    public double TotalCost()
    {
        return _price * _quatity;
    }
}