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
      int remainder = pastryCount % 3;
      if (pastryCount > 2)
      {
        pastryCost = (((pastryCount - remainder) / 3) * 5) + (remainder * 2);
      }
      else
      {
        pastryCost = pastryCount * 2;
      }
      return pastryCost;
    }
  }
}