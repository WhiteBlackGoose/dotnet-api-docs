using System;
using System.Runtime.Remoting;

   public class MyServerImpl :MarshalByRefObject
   {
     public MyServerImpl()
     {
         Console.WriteLine("Server Activated");
     }

     public string MyMethod(string name)
     {
         Console.WriteLine(name);
         return "The string from server : " + name;
     }
   }
