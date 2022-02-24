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
      //Arrange
      string number = "one";
      //Act
      string dictionaryValue = Numbers.belowTwenty["1"];
      //Assert
      Assert.AreEqual(number, dictionaryValue);
    }
    
    [TestMethod]
    public void NumbersSplitArray_CreateArray_Array()
    {
      string s = "1234";
      char[] arr = {'0','2','3','4'};
      char[] result = Numbers.SplitValue(s);
      CollectionAssert.AreEqual(arr,result);
    }
  }
}