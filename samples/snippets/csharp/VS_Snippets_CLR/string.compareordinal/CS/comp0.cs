//<snippet1>
// Sample for string.CompareOrdinal(string, string)
using System;

class Sample {
    public static void Main() {
    string str1 = "ABCD";
    string str2 = "abcd";
    string str;
    int result;

    Console.WriteLine();
    Console.WriteLine("Compare the numeric values of the corresponding char objects in each string.");
    Console.WriteLine("str1 = '{0}', str2 = '{1}'", str1, str2);
    result = string.CompareOrdinal(str1, str2);
    str = ((result < 0) ? "less than" : ((result > 0) ? "greater than" : "equal to"));
    Console.Write("string '{0}' is ", str1);
    Console.Write("{0} ", str);
    Console.WriteLine("string '{0}'.", str2);
    }
}
/*
This example produces the following results:

Compare the numeric values of the corresponding char objects in each string.
str1 = 'ABCD', str2 = 'abcd'
string 'ABCD' is less than string 'abcd'.
*/
//</snippet1>