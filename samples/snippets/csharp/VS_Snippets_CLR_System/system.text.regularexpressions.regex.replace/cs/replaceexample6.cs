// <Snippet6>
using System;
using System.Text.RegularExpressions;

public class Example
{
   public static void Main()
   {
      string input = "This is   text with   far  too   much   " + 
                     "white space.";
      string pattern = "\\s+";
      string replacement = " ";
      string result = Regex.Replace(input, pattern, replacement);
      
      Console.WriteLine("Original string: {0}", input);
      Console.WriteLine("Replacement string: {0}", result);                             
   }
}
// The example displays the following output:
//       Original string: This is   text with   far  too   much   white space.
//       Replacement string: This is text with far too much white space.
// </Snippet6>
