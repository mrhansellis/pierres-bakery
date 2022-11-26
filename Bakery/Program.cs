using System;
using Bakery.Models;


namespace Palindromes
{
  public class Program
  {
    public static void Main()
    {
      int finalTotal = 0;
      Console.WriteLine("Welcome to Pierre's Bakery where you'll find a beatuiful selection of bread and pastries!");
      Console.WriteLine("Would you like any bread today? y/n");
      string breadResponse = Console.ReadLine();
      string handleBreadResponse = breadResponse.ToLower();
      
      if (handleBreadResponse == "y")
      {
        Console.WriteLine("Bread Board: 5 bucks a loaf. Buy two get the third free. No limits!");
        Console.WriteLine("How many loaves of bread would you like?");
        int breadInput = Int32.Parse(Console.ReadLine());
        Bread newBread = new Bread(breadInput);
        finalTotal += newBread.BreadCost();
        Console.WriteLine("Would you care for any of our fine Pastries? y/n");
        string pastryResponse = Console.ReadLine();
        string handlePastryResponse = pastryResponse.ToLower();
      }
      else if (handleBreadResponse == "n")
      {
        Console.WriteLine("Thanks for stopping by.");
      }
      Console.WriteLine("Your total today will be $" + finalTotal);
    }
  }
}