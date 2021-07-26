// <Snippet13>
using System;
using System.Collections.Generic;

public class Person : IComparable<Person>
{
   public Person(string fName, string lName)
   {
      FirstName = fName;
      LastName = lName;
   }

   public string FirstName { get; set; }
   public string LastName { get; set; }

   public int CompareTo(Person other)
   {
      return string.Format("{0} {1}", LastName, FirstName).
             CompareTo(string.Format("{0} {1}", other.LastName, other.FirstName));
   }
}

public class Example
{
   public static void Main()
   {
      var people = new List<Person>();

      people.Add(new Person("John", "Doe"));
      people.Add(new Person("Jane", "Doe"));
      people.Sort();
      foreach (var person in people)
         Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
   }
}
// The example displays the following output:
//       Jane Doe
//       John Doe
// </Snippet13>
