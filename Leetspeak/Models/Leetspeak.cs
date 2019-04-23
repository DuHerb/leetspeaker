using System;
using System.Collections.Generic;

namespace Leetspeak
{
  public class Leetspeak
  {
    public string ConvertToLeetSpeak(string input)
    {
      // string letter = input;


      char[] array = input.ToCharArray();
      for(int i = 0; i < array.Length; i++)
      {
        if(array[i] == 'e')
        {
          array[i] = '3';
        }
        if(array[i] == 'o')
        {
          array[i] = '0';
        }
        if(array[i] == 'I')
        {
          array[i] = '1';
        }
        if(array[i] == 't')
        {
          array[i] = '7';
        }
        if(array[i] == 's' && array[i - 1] != ' ')
        {
          array[i] = 'z';
        }
      }
      string result = string.Join("", array);
      return result;
    }
  }

}
