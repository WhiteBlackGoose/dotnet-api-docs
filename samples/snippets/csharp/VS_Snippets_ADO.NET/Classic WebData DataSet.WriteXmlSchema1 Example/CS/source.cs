using System;
using System.Xml;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

public class Form1: Form
{
    protected DataSet DataSet1;
    protected DataGrid dataGrid1;

    // <Snippet1>
    private void WriteSchemaWithstringWriter(DataSet thisDataSet)
    {
        // Create a new stringBuilder object.
        System.Text.stringBuilder builder = new System.Text.stringBuilder();

        // Create the stringWriter object with the stringBuilder object.
        System.IO.stringWriter writer = new System.IO.stringWriter(builder);

        // Write the schema into the stringWriter.
        thisDataSet.WriteXmlSchema(writer);

        // Print the string to the console window.
        Console.WriteLine(writer.Tostring());
    }
    // </Snippet1>
}
