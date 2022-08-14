/*
Who remembers back to their time in the schoolyard, when girls would take a flower and tear its petals, saying each of the following phrases each time a petal was torn:

I love you
a little
a lot
passionately
madly
not at all
When the last petal was torn there were cries of excitement, dreams, surging thoughts and emotions.

Your goal in this kata is to determine which phrase the girls would say for a flower of a given number of petals, where nb_petals > 0.
*/

////
using System;

public class Kata
{
  public static string HowMuchILoveYou(int nb_petals)
  {
    // your code
    switch(nb_petals % 6){
        case 0: return "not at all"; break;
        case 1: return "I love you"; break;
        case 2: return "a little"; break;
        case 3: return "a lot"; break;
        case 4: return "passionately"; break;
        case 5: return "madly";
        default: return "";
    } 
  }
}

////
using System;

public class Kata
{
  public static string HowMuchILoveYou(int nb_petals)
  {
    return new string[] {"I love you", "a little", "a lot", "passionately", "madly", "not at all"}[(nb_petals - 1) % 6];
  }
}

////
using System;

public class Kata
{
  static string[] petalText = new string[] 
  {
    "I love you",
    "a little",
    "a lot",
    "passionately",
    "madly",
    "not at all"
  };
  
  public static string HowMuchILoveYou(int nb_petals)
  {
    return petalText[(nb_petals -1) % petalText.Length];
  }
}

////
public class Kata
{
    public static string HowMuchILoveYou(int nb_petals) =>
    (nb_petals % 6) switch
    {
        0 => "not at all",
        1 => "I love you",
        2 => "a little",
        3 => "a lot",
        4 => "passionately",
        5 => "madly"
    };
}

/////
