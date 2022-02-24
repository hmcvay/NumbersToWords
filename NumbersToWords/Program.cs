using System;
using System.Collections.Generic;
using NumbersToWords.Models;

namespace NumbersToWords
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("WELCOME!!");
      Console.WriteLine("This application will take a numeral and return that numeral written in words back tot he user.");
      Console.WriteLine("-------------------");
      Console.WriteLine("Please enter the numeral you wish to convert:");
      string response = Console.ReadLine();
      char[] arr = Numbers.SplitValue(response);
      foreach (char i in arr)
      {
        Console.WriteLine(i);
      }
    }
  }
}