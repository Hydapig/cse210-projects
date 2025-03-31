public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private double _totalPrice = 0;
    double _shippingCost;

    // private string _packingLabel;
    // private string _shippingLabel;
    public Order(Customer customer)
    {
        _customer = customer;
        _shippingCost = _customer.IsInUSA() ? 5 : 35;
    }
    public void AddProducts(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        foreach (var p in _products)
        {
            _totalPrice += p.CalculateTotalCost();
        }
        return _totalPrice + _shippingCost;
    }

    public string PackingLabel()
    {
        List<string> labels = new List<string>();
        foreach (var p in _products)
        {
            labels.Add($"{p.GetName} (ID: {p.GetProductId})");
        }
        return string.Join("\n", labels);
    }

    public string ShippingLabel()
    {
        return _customer.CustomerLocation();
    }
}