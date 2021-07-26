// <Snippet7>
using System;

public class Example
{
   public static void Main()
   {
      decimal price = 169.32m;
      Console.WriteLine("The cost is {0:Q2}.", price);
   }
}
// The example displays the following output:
//    Unhandled Exception: System.FormatException: Format specifier was invalid.
//       at System.Number.FormatDecimal(Decimal value, string format, NumberFormatInfo info)
//       at System.Decimal.ToString(string format, IFormatProvider provider)
//       at System.Text.StringBuilder.AppendFormat(IFormatProvider provider, string format, Object[] args)
//       at System.IO.TextWriter.WriteLine(string format, Object arg0)
//       at System.IO.TextWriter.SyncTextWriter.WriteLine(string format, Object arg0)
//       at Example.Main()
// </Snippet7>
