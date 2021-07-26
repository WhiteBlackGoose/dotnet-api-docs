//<Snippet1>
using System;

class Example
{
    public static void Main()
    {
        // Define an array of char values.
        Char[] values = { '\0', ' ', '*', 'A', 'a', '{', 'Æ' };

        // Convert each char value to a Decimal.
        foreach (var value in values) {
           decimal decValue = value;
           Console.WriteLine("'{0}' ({1}) --> {2} ({3})", value,
                             value.GetType().Name, decValue,
                             decValue.GetType().Name);
        }
    }
}
// The example displays the following output:
//       ' ' (char) --> 0 (Decimal)
//       ' ' (char) --> 32 (Decimal)
//       '*' (char) --> 42 (Decimal)
//       'A' (char) --> 65 (Decimal)
//       'a' (char) --> 97 (Decimal)
//       '{' (char) --> 123 (Decimal)
//       'Æ' (char) --> 198 (Decimal)
//</Snippet1>
