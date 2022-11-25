using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int Quantity { get; }

    public Bread(int quantity)
    {
      Quantity = quantity;
    }

    public int BreadCost(int quantity)
    {
      int breadCost = 0;
      breadCost = quantity * 5;
      return breadCost;
    }
  }
}