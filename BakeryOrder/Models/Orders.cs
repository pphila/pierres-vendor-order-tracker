using System;
using System.Collections.Generic;

namespace BakeryOrder.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Bread { get; set; }
    public int Pastry { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};

    public Order(string title, string description, int bread, int pastry, int price, string date)
    {
      Title = title;
      Description = description;
      Bread = bread;
      Pastry = pastry;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public void CalculatePrice()
    {
      int breadCost = (Bread *5) - ((int)Math.Floor((decimal)(Bread / 3) * 5));
      int pastryRemainder = Pastry % 3;
      int pastryTotal = (((Pastry - pastryRemainder) / 3) * 5) + (pastryRemainder * 2);
      Price = breadCost + pastryTotal;
    }
    
  }
}