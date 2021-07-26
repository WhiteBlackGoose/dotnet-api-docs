// This is the implementation class for the remote object.

using System;

    public class MyServerImpl :MarshalByRefObject
    {
        public MyServerImpl()
        {
        }

        public string MyMethod(string name)
        {
            return "The string from client is " + name;
        }
    }
