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

    public int BreadCost()
    {
      int breadCost = 0;
      int breadCount = Quantity;
      if (breadCount >= 3)
      {
        breadCost = (breadCount * 5) - (( breadCount / 3) * 5);
      }
      else
      {
        breadCost = breadCount * 5;
      }
      return breadCost;
    }
  }
}