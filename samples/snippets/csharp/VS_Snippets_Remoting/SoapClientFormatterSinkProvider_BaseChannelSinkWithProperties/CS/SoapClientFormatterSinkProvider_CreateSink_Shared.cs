/* This is supporting program for the 'SoapClientFormatterSinkProvider_CreateSink_Client'.
 */
using System;

public class HelloService : MarshalByRefObject
{
   public HelloService()
   {
      Console.WriteLine("Server Started ");
   }

   public string HelloMethod(string name)
   {
        return "Hi, " + name ;
    }
}
