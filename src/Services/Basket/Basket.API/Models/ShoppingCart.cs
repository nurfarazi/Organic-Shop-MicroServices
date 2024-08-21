﻿namespace Basket.API.Models;

public class ShoppingCart
{
    public ShoppingCart(string userName)
    {
        UserName = userName;
    }

    //Required for Mapping
    public ShoppingCart()
    {
    }

    public string UserName { get; set; } = default!;
    public List<ShoppingCartItem> Items { get; set; } = [];
    public decimal TotalPrice => Items.Sum(x => x.Price * x.Quantity);
}