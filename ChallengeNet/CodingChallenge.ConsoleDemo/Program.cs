using System;
using System.Collections.Generic;
using System.Linq;
using CodingChallenge.Lib;

namespace CodingChallenge.ConsoleDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("= FizzBuss =================");
      FizzBuss();

      Console.WriteLine("\n= Fibonacci =================");
      Fibonacci(10);

      Console.WriteLine("\n= Palindrome =================");
      Palindrome("racecar");
      Palindrome("mom");
      Palindrome("FizzBuzz");
      Palindrome("12344321");

      Console.WriteLine("\n= TwoSum =================");
      TwoSum(new List<int>(){1,2,4,5,8,9,17,23}, 5);
      TwoSum(new List<int>(){3, 9, 2, 11, 8, 23}, 17);

      Console.Read();
    }

    private static void Palindrome(string inStr)
    {
      var outStr = MixLib.IsPalindrome(inStr) ? " is a palindrome" : " is not a palindrome";
      Console.WriteLine($" {inStr} {outStr}");
    }

    private static void TwoSum(List<int> ints, int target)
    {
      var res = MixLib.TwoSum(ints, target);
      Console.WriteLine(string.Join(',', ints) + " -> " + target + " -> " + string.Join(',', res));
    }

    private static void Fibonacci(int n)
    {
      var seq = MixLib.FibonacciSequence(n);
      Console.WriteLine(string.Join(',', seq));
    }

    private static void FizzBuss()
    {
      for (int i = 1; i <= 100; i += 1)
      {
        string s = MixLib.FizzOrBuzz(i);
        if (!string.IsNullOrEmpty(s))
          Console.WriteLine($"{i} - {s}");
      }

    }



  }
}
