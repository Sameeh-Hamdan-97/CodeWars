/*
Is the string uppercase?
Task
Create a method to see whether the string is ALL CAPS.

Examples (input -> output)
"c" -> False
"C" -> True
"hello I AM DONALD" -> False
"HELLO I AM DONALD" -> True
"ACSKLDFJSgSKLDFJSKLDFJ" -> False
"ACSKLDFJSGSKLDFJSKLDFJ" -> True
*/

////
using System;
public static class StringExtensions
{
  public static bool IsUpperCase(this string text)
  {
    foreach(var ch in text){
      if(Char.IsLetter(ch) && !Char.IsUpper(ch)){
        return false;
      }
    }
    return true;
  }
}

////
public static class StringExtensions
{
  public static bool IsUpperCase(this string value) => value.ToUpper() == value;
}

////
using System;
using System.Linq;

public static class StringExtensions
{
  public static bool IsUpperCase(this string s) => !s.Any(x => Char.IsLower(x)); 
  }
}

////
using System.Collections.Generic;
using System.Linq;
public static class StringExtensions {
   public static bool IsUpperCase(this string s) => new List<char>(s).TrueForAll( x => !char.IsLower(x) );
}

////
using System.Text.RegularExpressions;

public static class StringExtensions{

  public static bool IsUpperCase(this string s) => Regex.IsMatch(s, "^$|^[^a-z]+$");
  
}

////
public static class StringExtensions{
  
  public static bool IsUpperCase(this string input)
  {
     return input.Equals(input.ToUpper());
  }
}
//
using System;

public static class StringExtensions{

 public static bool IsUpperCase( this string s)
 {
   return s.ToUpper().Equals(s);
 }
 
}

////
using System.Linq;
public static class StringExtensions
{
    public static bool IsUpperCase(this string text) => text.Replace(" ", "").All(x => char.IsUpper(x));
}

////
public static class StringExtensions
{
  //your code goes here...
  public static bool IsUpperCase(this string str)
  {
    int length = str.Length;
    int total = 0;
    foreach(var chr in str)
    {
      if(((chr >= 'A' && chr <= 'Z') && !(chr >= 'a' && chr <= 'z')) || chr == ' ')
      {
        total++;
      }
    }
    return total == length;
  }
}
