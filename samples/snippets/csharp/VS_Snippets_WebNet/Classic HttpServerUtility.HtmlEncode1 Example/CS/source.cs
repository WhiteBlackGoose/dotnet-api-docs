using System;
using System.IO;
using System.Web;
using System.Web.UI;

public class Page1: Page
{
 private void Page_Load(Object sender, EventArgs e)
 {
// <Snippet1>
string TestString = "This is a <Test string>.";
StringWriter writer = new StringWriter();
Server.HtmlEncode(TestString, writer);
string EncodedString = writer.ToString();

// </Snippet1>
 }
}
