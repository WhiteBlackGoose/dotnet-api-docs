// <Snippet6>
using System;

public class Example
{
   public static void Main()
   {
      string s1 = "We went to a bookstore, ";
      string s2 = "a movie, ";
      string s3 = "and a restaurant.";

      var s = string.Concat(s1, s2, s3);
      Console.WriteLine(s);
   }
}
// The example displays the following output:
//      We went to a bookstore, a movie, and a restaurant. 
// </Snippet6>
