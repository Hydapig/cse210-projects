using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private double _totalPrice = 0;
    double _shippingCost;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
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
        List<string> productList = new List<string>();
        foreach (var p in _products)
        {
            productList.Add(p.ProductList());
        }
        
        return String.Join("\n", productList);
    }

    public string ShippingLabel()
    {
        return _customer.CustomerLocation();
    }
}