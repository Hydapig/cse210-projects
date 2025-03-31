public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string prodID, double price, int quantity)
    {
        this._name = name;
        this._productId = prodID;
        this._price = price;
        this._quantity = quantity;
    }

    public double CalculateTotalCost()
    {
        return _price * _quantity;
    }

    public string GetName() 
    { 
        return _name; 
    }
    public string GetProductId()
    {
        return _productId;
    }
    public double GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
}