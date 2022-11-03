using System;
using System.Collections.Generic;

namespace Pairs_of_Songs_With_Total_Durations_Divisible_by_60
{
  class Program
  {
    static void Main(string[] args)
    {
      var time = new int[] { 30, 150, 90, 40 , 20 };
      Solution s = new Solution();
      var answer = s.NumPairsDivisibleBy60(time);
      Console.Write(answer);
    }
  }

  // https://leetcode.com/problems/pairs-of-songs-with-total-durations-divisible-by-60/discuss/636651/Java-Simple-Solution-with-with-a-crystal-clear-explanation(biginners-mindset)-HashMap-in-O(n)
  public class Solution
  {
    public int NumPairsDivisibleBy60(int[] time)
    {
      Dictionary<int, int> map = new Dictionary<int, int>();
      int cntr = 0;
      foreach (int t in time)
      {
        //Reason for an extra % 60 over(60 - t % 60).
        //if the t = 60, the expression 60 - t % 60 returns 60. this is beyond our remainers range(0,59)for 60.
        //to make it with in the range in the case of 60 and multiples of 60, we are ufing an extra % 60 on top of(60 - t % 60).
        //this makes the remainder 0.which is with in the range of remainders for 60(0, 59)
        int key = (60 - t % 60) % 60;
        if (!map.ContainsKey(key))
        {
          cntr += 0;
        }
        else
        {
          cntr += map[key];
        }
        key = t % 60;
        if (!map.ContainsKey(key))
        {
          map.Add(key, 0);
        }
        map[key] += 1;
      }
      return cntr;
    }
  }
}
