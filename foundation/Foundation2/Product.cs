using System;
using System.Collections.Generic;


public class Product
{
    private string _ID;
    private string _productName;
    private decimal _price;
    private int _quantity;


    public Product(string productName, string ID, decimal price, int quantity)
    {
        _ID = ID;
        _productName = productName;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }
    public decimal GetPrice()
    {
        return _price;
    }
    public string GetID()
    {
        return _ID;
    }
    public int GetQuantity()
    {
        return _quantity;
    }

    public decimal ProductCalc()
    {
        return _price * _quantity;
    }
}