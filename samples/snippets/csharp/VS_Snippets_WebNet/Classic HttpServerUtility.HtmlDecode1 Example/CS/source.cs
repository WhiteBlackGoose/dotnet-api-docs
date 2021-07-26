using System;
using System.IO;
using System.Web;
using System.Web.UI;

public class Page1: Page
{
 private void Page_Load(Object sender, EventArgs e)
 {
// <Snippet1>
string EncodedString = "This is a &ltTest string&gt.";
StringWriter writer = new StringWriter();
Server.HtmlDecode(EncodedString, writer);
string DecodedString = writer.ToString();

// </Snippet1>
 }
}
