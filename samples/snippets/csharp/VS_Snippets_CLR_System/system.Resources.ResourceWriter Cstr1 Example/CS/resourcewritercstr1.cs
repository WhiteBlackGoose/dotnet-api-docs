//<snippet1>
using System;
using System.Resources;
using System.IO;

public class WriteResources 
{
    public static void Main(string[] args) 
    {  
        // Create a file stream to encapsulate items.resources.
        FileStream fs = new FileStream("items.resources", 
        FileMode.OpenOrCreate,FileAccess.Write);

        // Open a resource writer to write from the stream.
        IResourceWriter writer = new ResourceWriter(fs);
    
        // Add resources to the resource writer.
        writer.AddResource("string 1", "First string");
        writer.AddResource("string 2", "Second string");
        writer.AddResource("string 3", "Third string");

        // Write the resources to the stream, and close it.
        writer.Close();
    }
}
//</snippet1>