// <Snippet1>
using System;
using System.Collections;
using System.Resources;

public class Example
{
   public static void Main()
   {
      Console.WriteLine("Resources in ApplicationResources.resources:");
      ResourceReader res = new ResourceReader(@".\ApplicationResources.resources");
      IDictionaryEnumerator dict = res.GetEnumerator();
      while (dict.MoveNext())
         Console.WriteLine("   {0}: '{1}' (Type {2})", 
                           dict.Key, dict.Value, dict.Value.GetType().Name);
      res.Close();
   }
}
// The example displays the following output:
//       Resources in ApplicationResources.resources:
//          Label3: '"Last Name:"' (Type string)
//          Label2: '"Middle Name:"' (Type string)
//          Label1: '"First Name:"' (Type string)
//          Label7: '"State:"' (Type string)
//          Label6: '"City:"' (Type string)
//          Label5: '"Street Address:"' (Type string)
//          Label4: '"SSN:"' (Type string)
//          Label9: '"Home Phone:"' (Type string)
//          Label8: '"Zip Code:"' (Type string)
//          Title: '"Contact Information"' (Type string)
//          Label12: '"Other Phone:"' (Type string)
//          Label13: '"Fax:"' (Type string)
//          Label10: '"Business Phone:"' (Type string)
//          Label11: '"Mobile Phone:"' (Type string)
//          Label14: '"Email Address:"' (Type string)
//          Label15: '"Alternate Email Address:"' (Type string)
// </Snippet1>
