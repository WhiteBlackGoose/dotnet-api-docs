// <Snippet3>
using System;
using System.Reflection;

public class Person
{
   public string FirstName;
   public string LastName;
   
   public override string ToString()
   {
      return (FirstName + " " + LastName).Trim();
   }
}

public class Example
{
   public static void Main()
   {
      Type t = typeof(Person);
      RetrieveMethod(t, "ToString");
      
      t = typeof(int);
      RetrieveMethod(t, "ToString");
   }

   private static void RetrieveMethod(Type t, string name)
   {   
      try {
         MethodInfo m = t.GetMethod(name);
         if (m != null) 
            Console.WriteLine("{0}.{1}: {2} method", m.ReflectedType.Name,
                              m.Name, m.IsStatic ? "Static" : "Instance");    
         else
            Console.WriteLine("{0}.ToString method not found", t.Name);
      }
      catch (AmbiguousMatchException) {
         Console.WriteLine("{0}.{1} has multiple public overloads.", 
                           t.Name, name);
      }
   }
}
// The example displays the following output:
//       Person.ToString: Instance method
//       int.ToString has multiple public overloads.
// </Snippet3>
