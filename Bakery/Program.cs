using System;
using Bakery.Models;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      int finalTotal = 0;
      Console.WriteLine("Welcome to Pierre's Bakery where you'll find a beatuiful selection of bread and pastries!");
      finalTotal += BreadTotal();
      finalTotal += PastryTotal();
      Console.WriteLine("Your total today will be $" + finalTotal);
    }
    
    public static int BreadTotal()
    {
      Console.WriteLine("Bread Board: $5 a loaf. Buy two get the third free. No limits!");
      Console.WriteLine("How many loaves of bread would you like?");
      int breadInput = HandleOrder();
      Bread newBread = new Bread(breadInput);
      int breadTotal = newBread.BreadCost();
      return breadTotal;
    }

    public static int PastryTotal()
    { 
      Console.WriteLine("Pastry Case: One for $2, Three for $5!");
      Console.WriteLine("How many pastries today?");
      int pastryInput = HandleOrder();
      Pastries newPastry = new Pastries(pastryInput);
      int pastryTotal = newPastry.PastryCost();
      return pastryTotal;
    }

    public static int HandleOrder()
    {
      int orderNumber = Int32.Parse(Console.ReadLine());
      return orderNumber;
    }
  }
}