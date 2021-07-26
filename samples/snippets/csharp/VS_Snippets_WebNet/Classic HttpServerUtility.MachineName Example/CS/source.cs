using System;
using System.Web;
using System.Web.UI;

public class Page1: Page
{
 private void Page_Load(Object sender, EventArgs e)
 {
// <Snippet1>
string ThisMachine;
ThisMachine = Server.MachineName;

// </Snippet1>
 }
}
