using System;

public class Example
{
   public static void Main()
   {
      // <Snippet2>
      string s1 = "String1";
      string s2 = "String1";
      Console.WriteLine("s1 = s2: {0}", Object.ReferenceEquals(s1, s2));
      Console.WriteLine("{0} interned: {1}", s1,
                        string.IsNullOrEmpty(string.IsInterned(s1)) ? "No" : "Yes");

      string suffix = "A";
      string s3 = "string" + suffix;
      string s4 = "string" + suffix;
      Console.WriteLine("s3 = s4: {0}", Object.ReferenceEquals(s3, s4));
      Console.WriteLine("{0} interned: {1}", s3,
                        string.IsNullOrEmpty(string.IsInterned(s3)) ? "No" : "Yes");

      // The example displays the following output:
      //       s1 = s2: True
      //       String1 interned: Yes
      //       s3 = s4: False
      //       StringA interned: No
      // </Snippet2>
   }
}
