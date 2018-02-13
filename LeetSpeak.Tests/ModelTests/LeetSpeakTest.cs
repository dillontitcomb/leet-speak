using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;
using System.Collections.Generic;
using LeetSpeak.Models;

namespace LeetSpeak.Tests
{
  [TestClass]
  public class PhraseTest
  {
    [TestMethod]
    public void FirstTestToArray()
    {
      Phrase newPhrase = new Phrase();
      newPhrase.SetPhrase("ab")
      char[] testArray = new char[] {'a','b'};
      CollectionAssert.AreEqual(testArray, newPhrase.ToArray());
    }

//This test confirms that the phrase is turned into an Array.


    [TestMethod]
    public void SecondTestToArray()
    {
      Phrase newPhrase = new Phrase();
      newPhrase.SetPhrase("eoIts");
      char[] testArray = new char[] {'3','0','1','7','z'};
      CollectionAssert.AreEqual(testArray, newPhrase.ToArray());

//This test confirms that all logic branching successfully works.

    }
  }
}
