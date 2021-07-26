using System;

    public class MyServerImpl :MarshalByRefObject
    {
        public MyServerImpl()
        {
            Console.WriteLine("Server Activated...");
        }

        public string MyMethod(string name)
        {
            return  "The client requests to "+name;
        }
    }
