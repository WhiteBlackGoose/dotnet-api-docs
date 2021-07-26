// <Snippet2>
using System;
using System.Reflection;

public class ReflectionUtilities
{   
   public static bool IsOverride(MethodInfo method)
   {
      return ! method.Equals(method.GetBaseDefinition());
   }
}

public class Example
{
   public static void Main()
   {
      MethodInfo equals = typeof(int).GetMethod("Equals", 
                                        new Type[] { typeof(Object) } );
      Console.WriteLine("{0}.{1} is inherited: {2}", 
                        equals.ReflectedType.Name, equals.Name,
                        ReflectionUtilities.IsOverride(equals));
      
      equals = typeof(Object).GetMethod("Equals", 
                                        new Type[] { typeof(Object) } );
      Console.WriteLine("{0}.{1} is inherited: {2}", 
                        equals.ReflectedType.Name, equals.Name,
                        ReflectionUtilities.IsOverride(equals));
   }
}
// The example displays the following output:
//       int.Equals is inherited: True
//       Object.Equals is inherited: False
// </Snippet2>
