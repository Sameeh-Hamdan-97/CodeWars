/*
Given an array of integers, return a new array with each value doubled.

For example:

[1, 2, 3] --> [2, 4, 6]
*/

////
public class Kata
{
  public static int[] Maps(int[] x)
  {
    for(int i=0;i<x.Length; i++){
      x[i]+=x[i];
    }
    return x;
  }
}

////
using System;
public class Kata
{
   public static int[] Maps(int[] x)
        {
            for(int i = 0;i<x.Length;i++)
            {
                x[i] *= 2;
            }
            return x;
        }
}

////
using System.Linq;

public class Kata
{
    public static int[] Maps(int[] x)
    {
        return x.Select(e => e*2).ToArray();
    }
}

////
using System.Linq;

public class Kata
{
    public static int[] Maps(int[] x) => x.Select(n => n * 2).ToArray();
}

////
using System.Linq;

public class Kata
{
  public static int[] Maps(int[] x) => x.Select(i => i + i).ToArray();
}

////
using System;
public class Kata
{
  public static int[] Maps(int[] x)
  {
    return Array.ConvertAll(x, n => n * 2);
  } 
}

