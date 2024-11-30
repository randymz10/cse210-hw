class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order() { }
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double TotalCost()
    {
        double totalPrice = 0;
        double shippingCostInUSA = 5;
        double shippingCostOutUSA = 35;

        _products.ForEach(p => totalPrice += p.TotalCost());

        if (_customer.LivingInUSA())
        {
            return totalPrice + shippingCostInUSA;
        }

        return totalPrice + shippingCostOutUSA;
    }
    public string PackingLabel()
    {
        string packingLabel = "";
        _products.ForEach(p => packingLabel += $"Product:{p.GetName()}, ID: {p.GetId()}\n");
        return packingLabel;
    }
    public string ShippingLabel()
    {
        return $"Customer Name: {_customer.GetName()}\nAddress: {_customer.ShowAddress()}";
    }

}