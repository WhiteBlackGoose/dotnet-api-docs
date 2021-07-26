// <Snippet8>
using System;
using System.Text.RegularExpressions;

public class Example
{
   public static void Main()
   {
      string str = "aabccdeefgghiijkklmm";
      string pattern = "(\\w)\\1"; 
      string replacement = "$1"; 
      Regex rgx = new Regex(pattern);

      string result = rgx.Replace(str, replacement, 5);
      Console.WriteLine("Original string:    '{0}'", str);
      Console.WriteLine("Replacement string: '{0}'", result); 
   }
}
// The example displays the following output:
//       Original string:    'aabccdeefgghiijkklmm'
//       Replacement string: 'abcdefghijkklmm'
// </Snippet8>
