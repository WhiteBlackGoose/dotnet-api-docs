//<snippet1>
// Sample for string.Equals(Object)
//            string.Equals(string)
//            string.Equals(string, string)
using System;
using System.Text;

class Sample {
    public static void Main() {
    StringBuilder sb = new StringBuilder("abcd");
    string      str1 = "abcd";
    string      str2 = null;
    Object	o2   = null;

    Console.WriteLine();
    Console.WriteLine(" *  The value of string str1 is '{0}'.", str1);
    Console.WriteLine(" *  The value of StringBuilder sb is '{0}'.", sb.ToString());

    Console.WriteLine();
    Console.WriteLine("1a) string.Equals(Object). Object is a StringBuilder, not a string.");
    Console.WriteLine("    Is str1 equal to sb?: {0}", str1.Equals(sb));

    Console.WriteLine();
    Console.WriteLine("1b) string.Equals(Object). Object is a string.");
    str2 = sb.ToString();
    o2   = str2;
    Console.WriteLine(" *  The value of Object o2 is '{0}'.", o2);
    Console.WriteLine("    Is str1 equal to o2?: {0}", str1.Equals(o2));

    Console.WriteLine();
    Console.WriteLine(" 2) string.Equals(string)");
    Console.WriteLine(" *  The value of string str2 is '{0}'.", str2);
    Console.WriteLine("    Is str1 equal to str2?: {0}", str1.Equals(str2));

    Console.WriteLine();
    Console.WriteLine(" 3) string.Equals(string, string)");
    Console.WriteLine("    Is str1 equal to str2?: {0}", string.Equals(str1, str2));
    }
}
/*
This example produces the following results:

 *  The value of string str1 is 'abcd'.
 *  The value of StringBuilder sb is 'abcd'.

1a) string.Equals(Object). Object is a StringBuilder, not a string.
    Is str1 equal to sb?: False

1b) string.Equals(Object). Object is a string.
 *  The value of Object o2 is 'abcd'.
    Is str1 equal to o2?: True

 2) string.Equals(string)
 *  The value of string str2 is 'abcd'.
    Is str1 equal to str2?: True

 3) string.Equals(string, string)
    Is str1 equal to str2?: True
*/
//</snippet1>