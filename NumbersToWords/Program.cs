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
      Start();
      static void Start()
      {
        Console.WriteLine("Please enter the numeral you wish to convert:");
        string response = Console.ReadLine();
        char[] arr = Numbers.SplitValue(response); 
        char[] toConvert = Numbers.ReverseArray(arr); 
        string dictionaryValue = Numbers.NumberConvert(toConvert); 
        Console.WriteLine("You number is: " + dictionaryValue);
        Console.WriteLine("-------------------");
        Start();
      }
    }
  }
}