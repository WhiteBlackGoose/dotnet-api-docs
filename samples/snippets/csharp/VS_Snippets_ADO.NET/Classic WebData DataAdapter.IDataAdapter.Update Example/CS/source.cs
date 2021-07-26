using System;
using System.Data;
using System.Text;
using System.Data.OleDb;

namespace DataAdapterIDataAdapterUpdateCS
{
    class Program
    {
        static void Main()
        {
            string connectionstring = GetConnectionstring();
            string querystring = "SELECT CompanyName FROM dbo.Shippers;";
            DataSet dataSet = CreateCommandAndUpdate(
                connectionstring, querystring);
            Console.ReadLine();
        }

        // <Snippet1>
        static private DataSet CreateCommandAndUpdate(
            string connectionstring,
            string querystring)
        {
            DataSet dataSet = new DataSet();

            using (OleDbConnection connection =
                       new OleDbConnection(connectionstring))
            {
                connection.Open();
                OleDbDataAdapter adapter =
                    new OleDbDataAdapter();
                adapter.SelectCommand =
                    new OleDbCommand(querystring, connection);
                OleDbCommandBuilder builder =
                    new OleDbCommandBuilder(adapter);

                adapter.Fill(dataSet);

                // Code to modify data in the DataSet here.

                // Without the OleDbCommandBuilder, this line would fail.
                adapter.UpdateCommand = builder.GetUpdateCommand();
                adapter.Update(dataSet);
            }
            return dataSet;
        }
        // </Snippet1>

        static private string GetConnectionstring()
        {
            // To avoid storing the connection string in your code,
            // you can retrieve it from a configuration file.
            return "Provider=sqloledb;Data Source=(local);Initial Catalog=Northwind;"
                + "Integrated Security=SSPI";
        }
    }
}
