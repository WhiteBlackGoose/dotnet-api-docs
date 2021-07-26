// <Snippet2>
using System;

public class Example
{
   public static void Main()
   {
      // Show hash code in current domain.
      DisplayString display = new DisplayString();
      display.ShowStringHashCode();
      
      // Create a new app domain and show string hash code.
      AppDomain domain = AppDomain.CreateDomain("NewDomain");
      var display2 = (DisplayString) domain.CreateInstanceAndUnwrap(typeof(Example).Assembly.FullName, 
                                                          "DisplayString");   
      display2.ShowStringHashCode();
   }
}

public class DisplayString : MarshalByRefObject
{
   private string s = "This is a string.";
   
   public override bool Equals(Object obj)
   {
      string s2 = obj as string; 
      if (s2 == null)
         return false;
      else
         return s == s2; 
   }

   public bool Equals(string str)
   {
      return s == str;
   }    
   
   public override int GetHashCode()
   {
      return s.GetHashCode();
   }
   
   public override string ToString() 
   {
      return s;
   }

   public void ShowStringHashCode()
   {
      Console.WriteLine("string '{0}' in domain '{1}': {2:X8}",
                        s, AppDomain.CurrentDomain.FriendlyName, 
                        s.GetHashCode());
   }
}
// </Snippet2>
