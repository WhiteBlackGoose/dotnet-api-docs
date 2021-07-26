// <Snippet1>
using System;
using System.Text;

class UnicodeEncodingExample {
    public static void Main() {
        UnicodeEncoding unicode = new UnicodeEncoding();
        string encodingName = unicode.EncodingName;
        Console.WriteLine("Encoding name: " + encodingName);
    }
}
// </Snippet1>
