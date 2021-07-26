// Sample for string.Join(string, String[], int int)
using System;

class Sample
{
    public static void Main()
    {
        //<snippet1>
        String[] val = {"apple", "orange", "grape", "pear"};
        string sep   = ", ";
        string result;

        Console.WriteLine("sep = '{0}'", sep);
        Console.WriteLine("val[] = {{'{0}' '{1}' '{2}' '{3}'}}", val[0], val[1], val[2], val[3]);
        result = string.Join(sep, val, 1, 2);
        Console.WriteLine("string.Join(sep, val, 1, 2) = '{0}'", result);

        // This example produces the following results:
        // sep = ', '
        // val[] = {'apple' 'orange' 'grape' 'pear'}
        // string.Join(sep, val, 1, 2) = 'orange, grape'
        //</snippet1>
    }
}
