using System;
using System.Collections.Generic;


public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal totalCost()
    {
        decimal total = 0;
        foreach (var product in _products)
        {
            total += product.ProductCalc();
        }                           // if it is true, return 5 and if false it returns 35
    total += _customer.LivesInUSA() ? 5:35;
    return total;
    }

    public string GetLabel()
    {
        string label = "Product label\n";
        foreach (var product in _products)
        {
            label += $"{product.GetProductName()}, ID: {product.GetID()}";
        }
    return label;
    }

    public string GetShippingAddress()
    {
        string shipping = "Shipping to:\n";
        shipping += $"{_customer.GetName()}, {_customer.GetAddress().dislayAddres()}";
        return shipping;
    }


}