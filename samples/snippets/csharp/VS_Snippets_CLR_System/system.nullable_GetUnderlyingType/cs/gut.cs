//<snippet1>
// This code example demonstrates the
// Nullable.GetUnderlyingType() method.

using System;
using System.Reflection;

class Sample
{
// Declare a type named Example.
// The MyMethod member of Example returns a Nullable of int.

    public class Example
    {
        public int? MyMethod()
        {
        return 0;
        }
    }

/*
   Use reflection to obtain a Type object for the Example type.
   Use the Type object to obtain a MethodInfo object for the MyMethod method.
   Use the MethodInfo object to obtain the type of the return value of
     MyMethod, which is Nullable of int.
   Use the GetUnderlyingType method to obtain the type argument of the
     return value type, which is int.
*/
    public static void Main()
    {
        Type t = typeof(Example);
        MethodInfo mi = t.GetMethod("MyMethod");
        Type retval = mi.ReturnType;
        Console.WriteLine("Return value type ... {0}", retval);
        Type answer = Nullable.GetUnderlyingType(retval);
        Console.WriteLine("Underlying type ..... {0}", answer);
    }
}
/*
This code example produces the following results:

Return value type ... System.Nullable`1[System.Int32]
Underlying type ..... System.Int32

*/
//</snippet1>