using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    //test to validate sentence
    [TestMethod]
    public void GetSentence_ReturnsSentenceInput_String()
    {
      //Arrange
      string sentence = "apple";
      RepeatCounter newRepeatCounter = new RepeatCounter(sentence, "");

      //Act
      string result = newRepeatCounter.GetSentence();

      //Assert
      Assert.AreEqual(sentence, result);
    }

    [TestMethod]
    public void SetSentence_SetSentenceInput_String()
    {
      //Arrange
      string sentence = "apple";
      RepeatCounter newRepeatCounter = new RepeatCounter(sentence, "");

      //Act
      string updatedSentence = "orange";
      newRepeatCounter.SetSentence(updatedSentence);
      string result = newRepeatCounter.GetSentence();

      //Assert
      Assert.AreEqual(updatedSentence, result);
    }

    //test to validate word
    [TestMethod]
    public void GetWord_ReturnsWordInput_String()
    {
      //Arrange
      string word = "apple";
      RepeatCounter newRepeatCounter = new RepeatCounter("", word);

      //Act
      string result = newRepeatCounter.GetWord();

      //Assert
      Assert.AreEqual(word, result);
    }

    [TestMethod]
    public void GetWord_ValidateWordInput_String()
    {
      //Arrange
      string word = "apple";
      RepeatCounter newRepeatCounter = new RepeatCounter("", word);

      //Act
      string updatedWord = "orange";
      newRepeatCounter.SetWord(updatedWord);
      string result = newRepeatCounter.GetWord();

      //Assert
      Assert.AreEqual(updatedWord, result);
    }

    //test to validate word count
    [TestMethod]
    public void CountRepeatWords_ValidateWordCountMethod_int()
    {
      //Arrange
      string word = "apple";
      string sentence = "apple apple";
      RepeatCounter newRepeatCounter = new RepeatCounter(sentence, word);

      //Act
      int result = newRepeatCounter.CountRepeatWords();

      //Assert
      Assert.AreEqual(2, result);
    }
  }
}
