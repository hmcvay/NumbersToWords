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
      string number = "two";
      //Act
      string dictionaryValue = Numbers.belowTwenty["1"];
      //Assert
      Assert.AreEqual(number, dictionaryValue);
    }
  }
}