// <Snippet1>
using System;

public class Example
{
   public unsafe static void Main()
   {
      string value = "This is the first sentence" + ".";
      fixed (char* start = value)
      {
         value = string.Concat(value, "This is the second sentence. ");
         fixed (char* current = value)
         {
            Console.WriteLine(start == current);
         }
      }   
   }
}
// The example displays the following output:
//      False
// </Snippet1>
