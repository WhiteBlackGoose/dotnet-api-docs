/* The class 'HelloServer' is derived from 'MarshalByRefObject' to make
   it remotable. Ihe method 'HelloMethod' can be called by the client
   after creating instance of the 'HelloServer' class.
*/
using System;

namespace RemotingSamples
{
   public class HelloServer : MarshalByRefObject
   {

      public HelloServer()
      {
         Console.WriteLine("HelloServer activated");
      }

      public string HelloMethod(string name)
      {
         Console.WriteLine("Hello.HelloMethod : {0}", name);
         return "Hi there " + name;
      }
   }
}
