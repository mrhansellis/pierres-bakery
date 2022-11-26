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

    public int PastryCost()
    {
      int pastryCost = 0;
      int pastryCount = PastryQuantity;

      pastryCost = (((pastryCount - (pastryCount % 3)) / 3) * 5) + ((pastryCount % 3) * 2);
      return pastryCost;
    }
  }
}