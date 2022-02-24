using System;
using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class Numbers
  {
      public static Dictionary<string, string> belowTwenty = new Dictionary<string, string>() 
      {{"1", "one"},
      {"2","two"},
      {"3", "three"},
      {"4", "four"},
      {"5", "five"},
      {"6", "six"},
      {"7", "seven"},
      {"8", "eight"},
      {"9", "nine"}};

    public static char[] SplitValue(string num) //static?
    {
      char[] result = num.ToCharArray();
      return result;
    }
  }
}