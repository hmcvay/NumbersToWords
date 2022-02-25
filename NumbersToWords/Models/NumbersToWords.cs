using System;
using System.Collections.Generic;

// TODO: Edge cases with zeros

namespace NumbersToWords.Models
{
  public class Numbers
  {
      public static Dictionary<char, string> belowTwenty = new Dictionary<char, string>() 
      {
        {'0', ""},
        {'1', "one "},
        {'2',"two "},
        {'3', "three "},
        {'4', "four"},
        {'5', "five "},
        {'6', "six "},
        {'7', "seven "},
        {'8', "eight "},
        {'9', "nine "}
      };

      public static Dictionary<string, string> teens = new Dictionary<string, string>() 
      {
        {"11", "eleven "},
        {"12", "twelve "},
        {"13", "thirteen "},
        {"14", "fourteen "},
        {"15", "fifteen "},
        {"16", "sixteen "},
        {"17", "seventeen "},
        {"18", "eighteen "},
        {"19", "nineteen "}
      };
      public static Dictionary<char, string> aboveTwenty = new Dictionary<char, string>() 
      {
        {'2', "twenty "},
        {'3', "thirty "},
        {'4', "forty "},
        {'5', "fifty "},
        {'6', "sixty "},
        {'7', "seventy "},
        {'8', "eighty "},
        {'9', "ninety "}
      };

    public static char[] SplitValue(string num)
    {
      char[] result = num.ToCharArray();
      return result;
    }

    public static char[] ReverseArray(char[] splitArray)
    {
      char[] result = splitArray;
      Array.Reverse(result);
      return result;
    }
    public static string NumberConvert(char[] array)
    {
      string numberInWords = "";
      for (int i = 0; i<array.Length; i++)
      {
        if (i==0)
        {
          char num = array[i];
          string str = Numbers.belowTwenty[num];
          numberInWords = numberInWords.Insert(0, str);
        }
        else if (i==1)
        {
          if (array[1] == '1')
          {
          numberInWords = "";
          string singles = Convert.ToString(array[i-1]);
          string tens = Convert.ToString(array[i]);
          string combined = tens + singles;
          string str = Numbers.teens[combined];
          numberInWords = numberInWords.Insert(0, str);
          }
          else
          {
          char num = array[i];
          string str = Numbers.aboveTwenty[num];
          numberInWords = numberInWords.Insert(0, str);
          }
        }
        else if (i==2)
        {
          char num = array[i];
          string str = Numbers.belowTwenty[num];
          numberInWords = numberInWords.Insert(0, "hundred ");
          numberInWords = numberInWords.Insert(0, str);
        }
        else
        {
          break;
        }
      } 
      return numberInWords;
    }
  }
}