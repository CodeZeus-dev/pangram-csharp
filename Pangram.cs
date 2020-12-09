using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        input = input.Replace(" ", String.Empty);
        char[] inputArray = input.ToCharArray(0, input.Length);
        char[] alphabet = new char[]
        {
          'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
          'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };

        int count = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (alphabet.Contains(Char.ToLower(inputArray[i])))
            {
                count += 1;
            }
        }

        if (count == inputArray.Length && count != 0)
        {
            return true;
        }

        return false;
    }
}
