// Sample for string.Compare(string, int, string, int, int, Boolean)
using System;

class Sample
{
    public static void Main()
    {
        //<snippet1>
        string str1 = "MACHINE";
        string str2 = "machine";
        string str;
        int result;

        Console.WriteLine();
        Console.WriteLine("str1 = '{0}', str2 = '{1}'", str1, str2);

        Console.WriteLine("Ignore case:");
        result = string.Compare(str1, 2, str2, 2, 2, true);
        str = ((result < 0) ? "less than" : ((result > 0) ? "greater than" : "equal to"));
        Console.Write("Substring '{0}' in '{1}' is ", str1.Substring(2, 2), str1);
        Console.Write("{0} ", str);
        Console.WriteLine("substring '{0}' in '{1}'.", str2.Substring(2, 2), str2);
        Console.WriteLine();

        Console.WriteLine("Honor case:");
        result = string.Compare(str1, 2, str2, 2, 2, false);
        str = ((result < 0) ? "less than" : ((result > 0) ? "greater than" : "equal to"));
        Console.Write("Substring '{0}' in '{1}' is ", str1.Substring(2, 2), str1);
        Console.Write("{0} ", str);
        Console.WriteLine("substring '{0}' in '{1}'.", str2.Substring(2, 2), str2);

        /*
        This example produces the following results:

        str1 = 'MACHINE', str2 = 'machine'
        Ignore case:
        Substring 'CH' in 'MACHINE' is equal to substring 'ch' in 'machine'.

        Honor case:
        Substring 'CH' in 'MACHINE' is greater than substring 'ch' in 'machine'.
        */
        //</snippet1>
    }
}
