/* Supporting file for the ITransportHeaders_3_Server.cs
 */
using System;

public class MyHelloServer : MarshalByRefObject
{
   public MyHelloServer()
   {
      Console.WriteLine("HelloServer activated...");
   }
   public string MyHelloMethod(string name)
   {
      Console.WriteLine("MyHelloServer.MyHelloMethod : {0}", name);
      return "Hello " + name ;
   }
}