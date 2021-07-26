using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace MissingMappingActionCS
{
    class Program
    {
        static void Main()
        {
            string connectionstring = GetConnectionstring();
            CreateOleDbAdapter(connectionstring);
        }
        // <Snippet1>
        // Assumes a valid connection string to an Access database.
        static void CreateOleDbAdapter(string connectionstring)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand =
                new OleDbCommand("SELECT * FROM Categories ORDER BY CategoryID");
            adapter.SelectCommand.Connection =
                new OleDbConnection(connectionstring);
            adapter.MissingMappingAction = MissingMappingAction.Error;
            adapter.MissingSchemaAction = MissingSchemaAction.Error;
        }
        // </Snippet1>
        static string GetConnectionstring()
        {
            return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=NWIND_RW.MDB";
        }
    }
}
