//<snippet20>
using System;
public class HelloServer : MarshalByRefObject
{
    public HelloServer(string myString)
    {
        Console.WriteLine("HelloServer activated");
        Console.WriteLine("Parameter passed to the constructor is "+myString);
    }
    public string HelloMethod(string myName)
    {
        Console.WriteLine("HelloMethod : {0}",myName);
        return "Hi there " + myName;
    }
}
//</snippet20>
