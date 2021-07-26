/*
   Supporting file: Common
*/

using System;

public class Foo : MarshalByRefObject
{
    // Print the string value.
    public void PrintString(string str)
    {
        Console.WriteLine("\n" + str);
    }
}