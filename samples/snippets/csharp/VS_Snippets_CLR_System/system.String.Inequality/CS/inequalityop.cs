//<snippet1>
// Example for the string Inequality operator.
using System;

class InequalityOp 
{
    public static void Main() 
    {
        Console.WriteLine( 
            "This example of the string Inequality operator\n" +
            "generates the following output.\n" );

        CompareAndDisplay( "ijkl" );
        CompareAndDisplay( "ABCD" );
        CompareAndDisplay( "abcd" );
    }

    static void CompareAndDisplay( string Comparand )
    {
        string  Lower = "abcd";

        Console.WriteLine( 
            "\"{0}\" != \"{1}\" ?  {2}",
            Lower, Comparand, Lower != Comparand );
    }
}

/*
This example of the string Inequality operator
generates the following output.

"abcd" != "ijkl" ?  True
"abcd" != "ABCD" ?  True
"abcd" != "abcd" ?  False
*/
//</snippet1>
