using System;
using System.Data;
using System.Windows.Forms;

public class Form1: Form
{
    protected DataSet DataSet1;

    // <Snippet1>
    private void AddDataColumn(DataTable table)
    {
        System.Type typeint =
            System.Type.GetType("System.Int32");
        DataColumn column = new DataColumn("id", typeint);

        // Set various properties.
        column.AutoIncrement = true;
        column.AutoIncrementSeed = 1;
        column.AutoIncrementStep = 1;
        column.ReadOnly = true;

        // Add to Columns collection.
        table.Columns.Add(column);
    }
    // </Snippet1>
}
