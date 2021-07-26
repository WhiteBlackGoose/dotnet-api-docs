// <Snippet2>
using System;

public class Example
{
   public static void Main()
   {
      bool flag = true;
      try {
         IConvertible conv = flag;
         char ch = conv.ToChar(null);
         Console.WriteLine("Conversion succeeded.");
      }
      catch (InvalidCastException) {
         Console.WriteLine("Cannot convert a Boolean to a char.");
      }

      try {
         char ch = Convert.ToChar(flag);
         Console.WriteLine("Conversion succeeded.");
      }
      catch (InvalidCastException) {
         Console.WriteLine("Cannot convert a Boolean to a char.");
      }
   }
}
// The example displays the following output:
//       Cannot convert a Boolean to a char.
//       Cannot convert a Boolean to a char.
// </Snippet2>
