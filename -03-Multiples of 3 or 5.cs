
/*
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in. Additionally, if the number is negative, return 0 (for languages that do have them).

Note: If the number is a multiple of both 3 and 5, only count it once.
*/

////

public static class Kata
{
  public static int Solution(int value)
  {
    int max = value - 1;
    int count3 = max / 3;
    int count5 = max / 5;
    int count15 = max / 15;
    return 3 * Sum(count3) + 5 * Sum(count5) - 15 * Sum(count15);
  }
  
  private static int Sum(int value)
  {
    return (1 + value) * value / 2;
  }
}


////

using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static int multiplierSum(int multipler, int n) {
    n--;
    return (multipler * ((n/multipler * (n/multipler + 1)) / 2));
  }
  
  public static int Solution(int n)
  {    
    var x3 = multiplierSum(3, n);
    var x5 = multiplierSum(5, n);
    var x15 = multiplierSum(15, n);
   
    return x3 + x5 - x15;;
  }
}

////

public static class Kata
{
  public static int Solution(int value)
  {
    value--;
    return SumMultiples(3, value) + SumMultiples(5, value) - SumMultiples(15, value);
  }
  
  private static int SumMultiples(int n, int limit) {
    return n * (1 + (limit / n)) * (limit / n) / 2;
  }
}

////

using System.Linq;

public static class Kata
{
    public static int Solution(int value)
    {
        return value < 3 ? 0 : Enumerable.Range(3, value - 3).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
    }
}

////

public static int Solution(int value)
  {
    int sum = 0;
    while (value-- > 0)
    {
        if (value % 5 == 0 || value % 3 == 0)
        {
            sum += value;
        }
    }
    return sum;
  }
