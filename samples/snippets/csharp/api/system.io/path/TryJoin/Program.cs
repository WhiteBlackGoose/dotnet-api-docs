using System;
using System.IO;

class Program
{
    static void Main()
    {
        int nchars = 0;
        var buffer = new Span<char>(new string(' ', 100).TocharArray());
        var flag = Path.TryJoin("C:/".AsSpan(), "Users/user1".AsSpan(), buffer, out nchars);
        if (flag) 
            Console.WriteLine($"Wrote {nchars} characters: '{buffer.Slice(0, nchars).Tostring()}'");
        else
            Console.WriteLine("Concatenation operation failed.");
    }
}
