/*
You will be given an array a and a value x. All you need to do is check whether the provided array contains the value.

Array can contain numbers or strings. X can be either.

Return true if the array contains the value, false if not.
*/

////
using System.Linq;

public class Kata
{
  public static bool Check(object[] a, object x) => a.Contains(x);
}

////
using System;

public class Kata {
  public static bool Check(object[] a, object x) => Array.IndexOf(a, x) != -1;
}

////
using System;
public class Kata
{
  public static bool Check(object[] a, object x)=>
     Array.Exists(a,e=>e.ToString()==x.ToString());

}

////
using System.Linq;
public class Kata {
  public static bool Check(object[] a, object x) {
    return a.ToList().Any(i => i.Equals(x));
  }
}
