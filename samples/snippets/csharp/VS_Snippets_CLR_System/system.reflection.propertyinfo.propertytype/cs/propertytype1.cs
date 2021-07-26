// <Snippet1>
using System;
using System.Reflection;

public class Employee
{
   private string _id;

   public string FirstName { get; set; }
   public string MiddleName { get; set; }
   public string LastName  { get; set; }
   public DateTime HireDate  { get; set; }

   public string ID
   {
      get { return _id; }
      set {
         if (ID.Trim().Length != 9)
            throw new ArgumentException("The ID is invalid");
         _id = value;
      }
   }
}

public class Example
{
   public static void Main()
   {
      Type t = typeof(Employee);
      Console.WriteLine("The {0} type has the following properties: ",
                        t.Name);
      foreach (var prop in t.GetProperties())
         Console.WriteLine("   {0} ({1})", prop.Name,
                           prop.PropertyType.Name);
   }
}
// The example displays the following output:
//       The Employee type has the following properties:
//          FirstName (string)
//          MiddleName (string)
//          LastName (string)
//          HireDate (DateTime)
//          ID (string)
// </Snippet1>
