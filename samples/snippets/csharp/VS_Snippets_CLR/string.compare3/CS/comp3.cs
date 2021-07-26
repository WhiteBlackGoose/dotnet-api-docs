// Sample for string.Compare(string, int, string, int, int)
using System;

class Sample
{
    public static void Main()
    {
        //<snippet1>
        string str1 = "machine";
        string str2 = "device";
        string str;
        int result;

        Console.WriteLine();
        Console.WriteLine("str1 = '{0}', str2 = '{1}'", str1, str2);
        result = string.Compare(str1, 2, str2, 0, 2);
        str = ((result < 0) ? "less than" : ((result > 0) ? "greater than" : "equal to"));
        Console.Write("Substring '{0}' in '{1}' is ", str1.Substring(2, 2), str1);
        Console.Write("{0} ", str);
        Console.WriteLine("substring '{0}' in '{1}'.", str2.Substring(0, 2), str2);

        /*
        This example produces the following results:

        str1 = 'machine', str2 = 'device'
        Substring 'ch' in 'machine' is less than substring 'de' in 'device'.
        */
        //</snippet1>
    }
}
