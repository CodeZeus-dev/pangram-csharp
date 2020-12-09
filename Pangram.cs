using System;
using System.Linq;
using System.Collections.Generic;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        input = input.Replace(" ", String.Empty);
        char[] inputArray = input.ToLower().ToCharArray(0, input.Length);

        char[] alphabet = new char[]
        {
          'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
          'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };

        IEnumerable<char> uniqueItems = inputArray.Distinct<char>();

        int count = 0;
        for (int i = 0; i < string.Join("", uniqueItems).Length; i++)
        {
            if (alphabet.Contains(string.Join("", uniqueItems)[i]))
            {
                count += 1;
            }
        }

        if (count == 26) { return true; }

        return false;
    }
}
