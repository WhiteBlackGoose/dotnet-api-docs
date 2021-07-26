using System;
using System.Globalization;

public class Example
{
    public static void Main()
    {
        Console.WriteLine("Hi!");
    }
}

// string.Compare(string,int,string,int,int)
public class CompareSample1_1
{
    //<Snippet2>
    static bool IsFileURI(String path)
    {
        return (String.Compare(path, 0, "file:", 0, 5, true) == 0);
    }
    //</Snippet2>
}

// string.Compare(string,int,string,int,int)
public class CompareSample1_2
{
    //<Snippet3>
    static bool IsFileURI(String path)
    {
        return (String.Compare(path, 0, "file:", 0, 5, StringComparison.OrdinalIgnoreCase) == 0);
    }
    //</Snippet3>
}

//string.Compare(string,int,string,int,int,System.Boolean)
public class CompareSample2_1
{
    //<Snippet4>
    static bool IsFileURI(String path)
    {
        return (String.Compare(path, 0, "file:", 0, 5, true) == 0);
    }
    //</Snippet4>
}

//string.Compare(string,int,string,int,int,System.Boolean)
public class CompareSample2_2
{
    //<Snippet5>
    static bool IsFileURI(String path)
    {
        return (String.Compare(path, 0, "file:", 0, 5, StringComparison.OrdinalIgnoreCase) == 0);
    }
    //</Snippet5>
}

//string.Compare(string,int,string,int,int,
//  System.Boolean,System.Globalization.CultureInfo)
public class CompareSample3_1
{
    //<Snippet6>
    static bool IsFileURI(String path)
    {
        return (String.Compare(path, 0, "file:", 0, 5, true) == 0);
    }
    //</Snippet6>
}

//string.Compare(string,int,string,int,int,
//  System.Boolean,System.Globalization.CultureInfo)
public class CompareSample3_2
{
    //<Snippet7>
    static bool IsFileURI(String path)
    {
        return (String.Compare(path, 0, "file:", 0, 5, StringComparison.OrdinalIgnoreCase) == 0);
    }
    //</Snippet7>
}

//string.Compare(string,int,string,int,
//  int,stringComparison)
public class CompareSample4_1
{
    //<Snippet8>
    static bool IsFileURI(String path)
    {
        return (String.Compare(path, 0, "file:", 0, 5, true) == 0);
    }
    //</Snippet8>
}

//string.Compare(string,int,string,int,
//  int,stringComparison)
public class CompareSample4_2
{
    //<Snippet9>
    static bool IsFileURI(String path)
    {
        return (String.Compare(path, 0, "file:", 0, 5, StringComparison.OrdinalIgnoreCase) == 0);
    }
    //</Snippet9>
}

//string.Compare(string,string)
public class CompareSample5_1
{
    //<Snippet10>
    static bool IsFileURI(String path)
    {
        return (String.Compare(path, 0, "file:", 0, 5, true) == 0);
    }
    //</Snippet10>
}

//string.Compare(string,string)
public class CompareSample5_2
{
    //<Snippet11>
    static bool IsFileURI(String path)
    {
        return (String.Compare(path, 0, "file:", 0, 5, StringComparison.OrdinalIgnoreCase) == 0);
    }
    //</Snippet11>
}

//string.Compare(string,string,System.Boolean)
public class CompareSample6_1
{
    //<Snippet12>
    static bool IsFileURI(String path)
    {
        return (String.Compare(path, 0, "file:", 0, 5, true) == 0);
    }
    //</Snippet12>
}

//string.Compare(string,string,System.Boolean)
public class CompareSample6_2
{
    //<Snippet13>
    static bool IsFileURI(String path)
    {
        return (String.Compare(path, 0, "file:", 0, 5, StringComparison.OrdinalIgnoreCase) == 0);
    }
    //</Snippet13>
}

//string.Compare(string,string,System.Boolean,System.Globalization.CultureInfo)
public class CompareSample7_1
{
    //<Snippet14>
    static bool IsFileURI(String path)
    {
        return (String.Compare(path, 0, "file:", 0, 5, true) == 0);
    }
    //</Snippet14>
}

//string.Compare(string,string,System.Boolean,System.Globalization.CultureInfo)
public class CompareSample7_2
{
    //<Snippet15>
    static bool IsFileURI(String path)
    {
        return (String.Compare(path, 0, "file:", 0, 5, StringComparison.OrdinalIgnoreCase) == 0);
    }
    //</Snippet15>
}

//string.Compare(string,string,stringComparison)
public class CompareSample8_1
{
    //<Snippet16>
    static bool IsFileURI(String path)
    {
        return (String.Compare(path, 0, "file:", 0, 5, true) == 0);
    }
    //</Snippet16>
}

//string.Compare(string,string,stringComparison)
public class CompareSample8_2
{
    //<Snippet17>
    static bool IsFileURI(String path)
    {
        return (String.Compare(path, 0, "file:", 0, 5, StringComparison.OrdinalIgnoreCase) == 0);
    }
    //</Snippet17>
}
