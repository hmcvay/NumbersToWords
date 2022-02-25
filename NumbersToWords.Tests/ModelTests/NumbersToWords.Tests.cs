using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;
using System.Collections.Generic; 

namespace NumbersToWords.Tests
{
  [TestClass]

  public class NumbersTests
  {
    [TestMethod]

    public void NumbersDictionary_ReturnValue_String()
    {
      string number = "one ";
      string dictionaryValue = Numbers.belowTwenty['1'];
      Assert.AreEqual(number, dictionaryValue);
    }
    
    [TestMethod]
    public void NumbersSplitArray_CreateArray_Array()
    {
      string s = "1234";
      char[] arr = {'1','2','3','4'};
      char[] result = Numbers.SplitValue(s);
      CollectionAssert.AreEqual(arr,result);
    }
    [TestMethod]
    public void NumbersReverseArray_ReverseArray_Array()
    {
      string s = "1234";
      char[] test = {'4','3','2','1'};
      char[] arr = Numbers.SplitValue(s);
      char[] result = Numbers.ReverseArray(arr);
      CollectionAssert.AreEqual(test,result);
    }

    [TestMethod]
    public void NumbersConvertArray_ConvertArray()
    {
      string s = "23";
      char[] arr = Numbers.SplitValue(s); // arr = '2', '3'
      char[] toConvert = Numbers.ReverseArray(arr); // toConvert = '3', '2'
      string dictionaryValue = Numbers.NumberConvert(toConvert); //dictionaryValue = "three" "twenty"
      //!
      // string reverseString = Numbers.ReverseString(dictionaryValue); //reverseString = "twenty three"
      string result = "twenty three ";
      Assert.AreEqual(dictionaryValue, result);
    }
  }
}