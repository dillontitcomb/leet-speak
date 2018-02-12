using System.Collections.Generic;
using System;

namespace LeetSpeak.Models
{
  public class Phrase
  {
    private string _phrase;

    public Phrase (string phrase)
    {
      _phrase = phrase;
    }

    public string GetPhrase()
    {
      return _phrase;
    }

    public void SetPhrase(string phrase)
    {
      _phrase = phrase;
    }
    //
    // public void Translate(string phrase)
    // {
    //   char[] phraseArray = phrase.ToCharArray();
    //   if (phraseArray.Contains("")
    // }
  }
}
