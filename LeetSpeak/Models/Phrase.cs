using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace LeetSpeak.Models
{
  public class Phrase
  {
    private string _phrase;

      public string GetPhrase()
    {
      return _phrase;
    }

    public void SetPhrase(string phrase)
    {
      _phrase = phrase;
    }

    public char[] ToArray()
    {
      char[] newArray = _phrase.ToCharArray();

      for(int i = 0; i < newArray.Length;i++)
      {
        if(newArray[i]=='e' || newArray[i] == 'E')
        {
          newArray[i] = '3';
        }
        else if (newArray[i] == 'o' || newArray[i] == 'O')
        {
          newArray[i] = '0';
        }
        else if (newArray[i] == 'I')
        {
          newArray[i] = '1';
        }
        else if (newArray[i] == 't' || newArray[i] == 'T')
        {
          newArray[i] = '7';
        }
        else if (newArray[i] == 's' || newArray[i] == 'S')
        {
          if ( i ==  0 )
          {
            newArray[i] = 'S';
          }

          else
          {
            newArray[i] = 'z';
          }
        }
      }
      return newArray;
    }
  }
}
