using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Lib
{
    public static class MixLib
    {
      public static List<int> TwoSum(List<int> numbers, int target)
      {
        for (int i = 0; i < numbers.Count; i += 1)
        {
          int rem = target - numbers[i];
          for (int j = i + 1; j < numbers.Count; j += 1)
          {
            if(numbers[j] == rem)
              return new List<int>(){i, j};
          }
        }
        return new List<int>();
      }
      public static List<int> FibonacciSequence(int total)
      {
        List<int> fSeq = new List<int>(); 
        
        if (total >= 1) fSeq.Add(1);
        if (total >= 2) fSeq.Add(1);

        for (int i = 3, n1=1, n2 = 1; i <= total; i += 1)
        {
          int n3 = n1 + n2;
          fSeq.Add(n3);
          n1 = n2;
          n2 = n3;
        }

        return fSeq;
      }
      public static bool IsPalindrome(string s)
      {
        int len = s.Length;
        if (len <= 1) return true;

        int halfLen = len / 2;

        for (int i = 0; i <= halfLen; i += 1)
        {
          if (s[i] != s[len - 1 - i])
            return false;
        }
        return true;
      }
      public static string FizzOrBuzz(int i)
      {
        StringBuilder s = new StringBuilder("");
        if (i <= 0) return "";
        if (i % 3 == 0) s.Append($"fizz");
        if (i % 5 == 0) s.Append("buzz");
        return s.ToString();
      }
    }
}
