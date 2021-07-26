using System;

class Sample
{
    public static void Main()
    {
    //<snippet1>
    string s1 = "abcd";
    string s2 = "";
    string s3 = null;

    Console.WriteLine("string s1 {0}.", Test(s1));
    Console.WriteLine("string s2 {0}.", Test(s2));
    Console.WriteLine("string s3 {0}.", Test(s3));

    string Test(string s)
    {
    if (string.IsNullOrEmpty(s))
        return "is null or empty";
    else
        return string.Format("(\"{0}\") is neither null nor empty", s);
    }

    // The example displays the following output:
    //       string s1 ("abcd") is neither null nor empty.
    //       string s2 is null or empty.
    //       string s3 is null or empty.
    // </snippet1>
    }
}
