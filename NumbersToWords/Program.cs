using System;
using System.Collections.Generic;
using NumbersToWords.Models;

namespace NumbersToWords
{
  public class Program
  {
    public static void Main()
    {
      Numbers.belowTwenty.Add("2", "two");
      Console.WriteLine("Is the program working correctly?");

      Console.WriteLine(Numbers.belowTwenty["2"]);
    }
  }
}