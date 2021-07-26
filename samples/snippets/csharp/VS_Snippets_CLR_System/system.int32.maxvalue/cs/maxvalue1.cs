// <Snippet1>
using System;

public class Class1
{
   public static void Main()
   {
      long[] numbersToConvert = { 162345, 32183, -54000, Int64.MaxValue/2 };
      int newNumber;
      foreach (long number in numbersToConvert)
      {
         if (number >= int.MinValue && number <= int.MaxValue)
         {
            newNumber = Convert.ToInt32(number);
            Console.WriteLine($"Successfully converted {newNumber} to an int.");
         }
         else
         {
            Console.WriteLine($"Unable to convert {number} to an int.");
         }
      }
   }
}
// The example displays the following output to the console:
//    Successfully converted 162345 to an int.
//    Successfully converted 32183 to an int.
//    Successfully converted -54000 to an int.
//    Unable to convert 4611686018427387903 to an int.
// </Snippet1>
