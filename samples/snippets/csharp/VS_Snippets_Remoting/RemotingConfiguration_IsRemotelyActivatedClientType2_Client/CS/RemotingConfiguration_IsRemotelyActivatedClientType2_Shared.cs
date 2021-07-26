using System;

    public class MyServerImpl :MarshalByRefObject
      {
         int i;
        public MyServerImpl()
        {
            i=0;
            Console.WriteLine("Server Activated...");
        }

        public string MyMethod(string name)
        {
         i=i+1;
            return "The client requests to "+name +i+" time";
        }
    }
