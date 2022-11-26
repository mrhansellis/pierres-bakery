using System;

namespace Bakery.Models
{
  public class Pastries
  {
    public int PastryQuantity { get; }
    public Pastries(int pastryQuantity)
    {
      PastryQuantity = pastryQuantity;
    }
  }
}